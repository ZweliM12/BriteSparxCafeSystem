
namespace BriteSparxCafeSystem
{
    partial class SalesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GroupWst17DataSet2 = new BriteSparxCafeSystem.GroupWst17DataSet2();
            this.OrderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderItemTableAdapter = new BriteSparxCafeSystem.GroupWst17DataSet2TableAdapters.OrderItemTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupWst17DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesReportToolStripMenuItem.Text = "Sales report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
            // 
            // Report
            // 
            this.Report.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrderItemBindingSource;
            this.Report.LocalReport.DataSources.Add(reportDataSource1);
            this.Report.LocalReport.ReportEmbeddedResource = "BriteSparxCafeSystem.SalesReport.rdlc";
            this.Report.Location = new System.Drawing.Point(0, 24);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(1137, 559);
            this.Report.TabIndex = 1;
            this.Report.Visible = false;
            // 
            // GroupWst17DataSet2
            // 
            this.GroupWst17DataSet2.DataSetName = "GroupWst17DataSet2";
            this.GroupWst17DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrderItemBindingSource
            // 
            this.OrderItemBindingSource.DataMember = "OrderItem";
            this.OrderItemBindingSource.DataSource = this.GroupWst17DataSet2;
            // 
            // OrderItemTableAdapter
            // 
            this.OrderItemTableAdapter.ClearBeforeFill = true;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 583);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupWst17DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer Report;
        private System.Windows.Forms.BindingSource OrderItemBindingSource;
        private GroupWst17DataSet2 GroupWst17DataSet2;
        private GroupWst17DataSet2TableAdapters.OrderItemTableAdapter OrderItemTableAdapter;
    }
} 