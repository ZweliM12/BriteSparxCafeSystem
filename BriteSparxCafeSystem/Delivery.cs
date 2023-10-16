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
{
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds1.Delivery_Cust' table. You can move, or remove it, as needed.
            this.delivery_CustTableAdapter.Fill(this.ds1.Delivery_Cust);

            // TODO: This line of code loads data into the 'groupWst17DataSet1.Customer' table. You can move, or remove it, as needed.
            this.taCustomer1.Fill(this.groupWst17DataSet1.Customer);
            if (LoginForm.username == "velaphiBSC" && LoginForm.password == "velaphi@23")
            {
                this.delivery_CustTableAdapter.Fill(this.ds1.Delivery_Cust);
                DataView dataView = ds1.Tables["delivery_Cust"].DefaultView;
                string filterExpression = "order_status = 'complete' AND delivery_point_name IS NOT NULL AND delivery_point_name = 'Quad'";
                dataView.RowFilter = filterExpression;
                dataGridView1.DataSource = dataView;
            }
            else if (LoginForm.username == "sesaneBSC" && LoginForm.password == "sesane@15")
            {
                this.delivery_CustTableAdapter.Fill(this.ds1.Delivery_Cust);
                DataView dataView = ds1.Tables["delivery_Cust"].DefaultView;
                string filterExpression = "order_status = 'complete' AND delivery_point_name IS NOT NULL AND delivery_point_name = 'L Block'";
                dataView.RowFilter = filterExpression;
                dataGridView1.DataSource = dataView;
            }
            else if (LoginForm.username == "nxumaloBSC" && LoginForm.password == "nxumalo@01")
            {
                this.delivery_CustTableAdapter.Fill(this.ds1.Delivery_Cust);
                DataView dataView = ds1.Tables["delivery_Cust"].DefaultView;
                string filterExpression = "order_status = 'complete' AND delivery_point_name IS NOT NULL AND delivery_point_name = 'G Block Bus Stop'";
                dataView.RowFilter = filterExpression;
                dataGridView1.DataSource = dataView;
            }
            else if (LoginForm.username == "shabalalaBSC" && LoginForm.password == "shabalala@06")
            {
                this.delivery_CustTableAdapter.Fill(this.ds1.Delivery_Cust);
                DataView dataView = ds1.Tables["delivery_Cust"].DefaultView;
                string filterExpression = "order_status = 'complete' AND delivery_point_name IS NOT NULL AND delivery_point_name = 'Sports Centre'";
                dataView.RowFilter = filterExpression;
                dataGridView1.DataSource = dataView;
            }
            else if (LoginForm.username == "gumbiBSC" && LoginForm.password == "gumbi@09")
            {
                this.delivery_CustTableAdapter.Fill(this.ds1.Delivery_Cust);
                DataView dataView = ds1.Tables["delivery_Cust"].DefaultView;
                string filterExpression = "order_status = 'complete' AND delivery_point_name IS NOT NULL AND delivery_point_name = 'Forest Hill Residence'";
                dataView.RowFilter = filterExpression;
                dataGridView1.DataSource = dataView;
            }
            else if (LoginForm.username == "nseleBSC" && LoginForm.password == "nsele@07")
            {
                this.delivery_CustTableAdapter.Fill(this.ds1.Delivery_Cust);
                DataView dataView = ds1.Tables["delivery_Cust"].DefaultView;
                string filterExpression = "order_status = 'complete' AND delivery_point_name IS NOT NULL AND delivery_point_name = 'd(Church)'";
                dataView.RowFilter = filterExpression;
                dataGridView1.DataSource = dataView;
            }
            else if (LoginForm.username == "nyembeBSC" && LoginForm.password == "nyembe@04")
            {
                this.delivery_CustTableAdapter.Fill(this.ds1.Delivery_Cust);
                DataView dataView = ds1.Tables["delivery_Cust"].DefaultView;
                string filterExpression = "order_status = 'complete' AND delivery_point_name IS NOT NULL AND delivery_point_name = 'O Block'";
                dataView.RowFilter = filterExpression;
                dataGridView1.DataSource = dataView;
            } 

            else
            {
                this.delivery_CustTableAdapter.Fill(this.ds1.Delivery_Cust);
                DataView dataView = ds1.Tables["delivery_Cust"].DefaultView;
                string filterExpression = "order_status = 'delivered' AND delivery_point_name IS NOT NULL";
                dataView.RowFilter = filterExpression;
                dataGridView1.DataSource = dataView;
                //updateOSbutton.Visible = false;
                //updateOScomboBox.Visible = false;
                //gvCustomer.Visible = false;
                //button1.Visible = false;
                //button2.Visible = false;
                //custIdtextBox.Visible = false;
            }

        }

         private void updateOSbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int orderID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string newStatus = updateOScomboBox.SelectedItem.ToString();
                string qoh = taOrder1.UpdateOrderStatus(newStatus, orderID).ToString();
                dataGridView1.CurrentRow.Cells[5].Value = newStatus;
                MessageBox.Show("Order status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the order status: " + ex.Message);
            }
            this.delivery_CustTableAdapter.Fill(this.ds1.Delivery_Cust);
        }
            private void ExitButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
