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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GroupWst17DataSet.OrderTable' table. You can move, or remove it, as needed.
            this.OrderTableTableAdapter.Fill(this.GroupWst17DataSet.OrderTable);

            this.Report.RefreshReport();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.Visible = true;
        }
    }
}
