using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BriteSparxCafeSystem
{   public partial class LoginForm : Form
    {
        public static string username;
        public static string password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if(userNametextBox.Text=="")
            {
                MessageBox.Show("Enter username");
            }
            else if(passwordtextBox.Text=="")
            {
                MessageBox.Show("Enter password");
            }
            else
            {
                    SqlConnection con = new SqlConnection("removed for security");
                    SqlCommand command = new SqlCommand("Select * from Staff where username=@username and password=@password", con);
                    command.Parameters.AddWithValue("@username", userNametextBox.Text);
                    command.Parameters.AddWithValue("@password", passwordtextBox.Text);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    username = userNametextBox.Text;
                    password = passwordtextBox.Text;
                    MainForm mf = new MainForm();
                    mf.Logoutbutton.Enabled = true;
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    userNametextBox.Text = "";
                    passwordtextBox.Text = "";
                }
            }
        }

        private void ShowcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowcheckBox.Checked == true)
            {
                passwordtextBox.UseSystemPasswordChar = true;
            }
            else
            {
                passwordtextBox.UseSystemPasswordChar = false;
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            userNametextBox.Text = "";
            passwordtextBox.Text = "";
            ShowcheckBox.Checked = false;
        }
        private void userNametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformLogin();
            }
        }

        private void passwordtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformLogin();
            }
        }

        private void PerformLogin()
        {
            if (userNametextBox.Text == "")
            {
                MessageBox.Show("Enter username");
            }
            else if (passwordtextBox.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            else
            {
                SqlConnection con = new SqlConnection("removed for security");
                SqlCommand command = new SqlCommand("Select * from Staff where username=@username and password=@password", con);
                command.Parameters.AddWithValue("@username", userNametextBox.Text);
                command.Parameters.AddWithValue("@password", passwordtextBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    username = userNametextBox.Text;
                    password = passwordtextBox.Text;
                    MainForm mf = new MainForm();
                    mf.Logoutbutton.Enabled = true;
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    userNametextBox.Text = "";
                    passwordtextBox.Text = "";
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sendCode codeForm = new sendCode();
            this.Hide();
            codeForm.Show();

        }
    }
}
