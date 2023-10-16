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
    public partial class PlaceOrderHelpCentre : Form
    {
        public PlaceOrderHelpCentre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpCentre helpC = new HelpCentre();
            helpC.Show();
            this.Hide();
        }
    }
}
