using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace BriteSparxCafeSystem
{
    public partial class resetPassword : Form
    {
        string email_address = sendCode.to;
        public resetPassword()
        {
            InitializeComponent();
        }

        /*   private void button1_Click(object sender, EventArgs e)
           {
               if(textBox1.Text == textBox2.Text)
               {
                   SqlConnection con = new SqlConnection("removed for security");
                   SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Staff] SET [password] = '" + textBox2.Text + "' WHERE email_address = '" + email_address + "' ", con);
                   con.Open();
                   cmd.ExecuteNonQuery();
                   con.Close();
                   MessageBox.Show("Password changed successfylly");


               }
               else
               {
                   MessageBox.Show("New password does not match");
               }

           }*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                string connectionString = "removed for security";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("UpdatePassword", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@EmailAddress", textBox1.Text); // Make sure 'email_address' has a valid value
                        cmd.Parameters.AddWithValue("@NewPassword", textBox2.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Email address not found.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("New password does not match");
            }
        }

     
    }
}
