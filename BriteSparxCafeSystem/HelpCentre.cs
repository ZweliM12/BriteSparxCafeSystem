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
    public partial class HelpCentre : Form
    {
        public HelpCentre()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Set the DropDownStyle to DropDownList to make it read-only
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            if (comboBox.SelectedIndex == 0)
            {
                this.Hide();
                HelpCentreAddCustomer form2 = new HelpCentreAddCustomer();
                form2.Show();
            }
            else if (comboBox.SelectedIndex == 1)
            {
                this.Hide();
                ArchiveHelpCentre form3 = new ArchiveHelpCentre();
                form3.Show();
            }
            else
            {
                this.Hide();
                UpdateCustomerHelpCentre form4 = new UpdateCustomerHelpCentre();
                form4.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            this.Hide();

           
            DeliveryHelpCentre form5 = new DeliveryHelpCentre();
            form5.Show();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cBox = (ComboBox)sender;
            if (cBox.SelectedIndex == 0)  
            {
               
                this.Hide();

                
                PlaceOrderHelpCentre form6 = new PlaceOrderHelpCentre();
                form6.Show();
            }
            else
            {

                
                this.Hide();

               
                UpdateOrderStatusHelpCentre form7 = new UpdateOrderStatusHelpCentre();
                form7.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            
            StockHelpCentre form8 = new StockHelpCentre();
            form8.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();

           
            ReportsHelpCentre form9 = new ReportsHelpCentre();
            form9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
