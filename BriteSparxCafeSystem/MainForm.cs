using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BriteSparxCafeSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void FormSetup(Form myForm)
        {
            foreach (Form C in this.MdiChildren)
            {
                C.Close();
            }
            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerForm nc = new AddCustomerForm();
            Headerpanel.Visible = false;
            SubHeaderpanel.Visible = false;
            MainpictureBox.Visible = false;
            FormSetup(nc);
        }

        private void makeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMenuForm mf = new AddMenuForm();
            Headerpanel.Visible = false;
            SubHeaderpanel.Visible = false;
            MainpictureBox.Visible = false;
            FormSetup(mf);
        }

        private void adddNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategoryForm cf = new AddCategoryForm();
            Headerpanel.Visible = false;
            SubHeaderpanel.Visible = false;
            MainpictureBox.Visible = false;
            FormSetup(cf);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            staffTableAdapter1.FillByUser(groupWst17DataSet1.Staff, LoginForm.username, LoginForm.password);
            LogAsLabel.Text = "Active User: "+LoginForm.username.ToString();
            if (groupWst17DataSet1.Staff.Rows[0][5].ToString() == "Kitchen Staff")
            {
                ordersToolStripMenuItem.Enabled = true;
            }
            else if(groupWst17DataSet1.Staff.Rows[0][5].ToString() == "Delivery Driver")
            {
                deliveryToolStripMenuItem.Enabled = true;
            }
            else  if(groupWst17DataSet1.Staff.Rows[0][5].ToString() == "Cashier")
            {
                customerTSMI.Enabled = true;
            }
            else
            {
                ordersToolStripMenuItem.Enabled = true;
                deliveryToolStripMenuItem.Enabled = true;
                customerTSMI.Enabled = true;
                categoriesToolStripMenuItem.Enabled = true;
                menuToolStripMenuItem.Enabled = true;
                reportsToolStripMenuItem.Enabled = true;
            }
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Log Out?","Exit Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                // Close the current form (main form)
                this.Close();

                // Create a new instance of the login form and show it
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void approvedOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApprovedOrdersForm of = new ApprovedOrdersForm();
            Headerpanel.Visible = false;
            SubHeaderpanel.Visible = false;
            MainpictureBox.Visible = false;
            FormSetup(of);
        }

        private void confirmDeliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delivery d = new Delivery();
            Headerpanel.Visible = false;
            SubHeaderpanel.Visible = false;
            MainpictureBox.Visible = false;
            FormSetup(d);
        }

        private void generateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            Headerpanel.Visible = false;
            SubHeaderpanel.Visible = false;
            MainpictureBox.Visible = false;
            FormSetup(rf);

        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            Headerpanel.Visible = false;
            SubHeaderpanel.Visible = false;
            MainpictureBox.Visible = false;
            FormSetup(sr);
        }

        private bool exitButtonClicked = false;

        private void MainForm_Exit(object sender, EventArgs e)
        {
            exitButtonClicked = true;
            Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exitButtonClicked)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpCentre frm = new HelpCentre();
            frm.Show();
        }

    }
}
