using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BriteSparxCafeSystem
{
    public partial class ApprovedOrdersForm : Form
    {
        public ApprovedOrdersForm()
        {
            InitializeComponent();
        }
        
        private void MakeOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds1.OrderDetailsUpdated' table. You can move, or remove it, as needed.
            this.orderDetailsUpdatedTableAdapter.Fill(this.ds1.OrderDetailsUpdated);
            // TODO: This line of code loads data into the 'ds1.MenuUpdated' table. You can move, or remove it, as needed.
            this.menuUpdatedTableAdapter.Fill(this.ds1.MenuUpdated);
            // TODO: This line of code loads data into the 'ds1.OrderTableUpdated' table. You can move, or remove it, as needed.
            this.orderTableUpdatedTableAdapter.Fill(this.ds1.OrderTableUpdated);
            // TODO: This line of code loads data into the 'groupWst17DataSet.OrderTable' table. You can move, or remove it, as needed.
            this.taOrder1.Fill(this.ds1.OrderTable);

            DataView dataView = ds1.Tables["orderTableUpdated"].DefaultView;
            string filterExpression = "order_status = 'pending' OR order_status = 'preparing'";
            dataView.RowFilter = filterExpression;
            gvOrderTUpdated.DataSource = dataView;
            gvOrderTUpdated.Refresh();

        }

        private void updateOSbutton_Click(object sender, EventArgs e)
        {
            gvOrderTUpdated.Refresh();

            try
            {
                int orderID = int.Parse(gvOrderTUpdated.CurrentRow.Cells[0].Value.ToString());
                string newStatus = updateOScomboBox.SelectedItem.ToString();
                string qoh = taOrder1.UpdateOrderStatus(newStatus, orderID).ToString();
                gvOrderTUpdated.CurrentRow.Cells[5].Value = newStatus;

                // Optional: Display a message to confirm the update
                MessageBox.Show("Order status updated successfully.");
                gvOrderTUpdated.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the order status: " + ex.Message);
            }
            this.orderTableUpdatedTableAdapter.Fill(this.ds1.OrderTableUpdated);
            gvOrderTUpdated.Refresh();
        }
 
        private void updateQOHbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update quantity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int v1 = int.Parse(updateQOHtextBox.Text);
                    int v2 = int.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString());
                    int v3 = v1 + v2;

                    if (v3 >= 0)
                    {
                        menuUpdatedTableAdapter.UpdateQOH(int.Parse(updateQOHtextBox.Text), int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString())).ToString();
                        menuUpdatedTableAdapter.FillByName(ds1.MenuUpdated, dataGridView2.CurrentRow.Cells[0].ToString());
                        this.menuUpdatedTableAdapter.Fill(this.ds1.MenuUpdated);
                    }
                    else
                    {
                        MessageBox.Show("QOH cannot be less than zero");
                    }
                }
                else
                {
                    updateQOHtextBox.Text = "";
                }
                updateQOHtextBox.Text = "";
            }
            catch
            {
                MessageBox.Show("Please enter valid value to update");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvOrderTUpdated_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int orderID = 0;
                orderID = (int)gvOrderTUpdated.CurrentRow.Cells[0].Value;
                orderDetailsUpdatedTableAdapter.FillByOrderID(ds1.OrderDetailsUpdated, orderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
