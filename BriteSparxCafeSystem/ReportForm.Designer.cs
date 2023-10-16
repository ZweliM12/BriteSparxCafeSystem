namespace BriteSparxCafeSystem
{
    partial class ReportForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GroupWst17DataSet = new BriteSparxCafeSystem.GroupWst17DataSet();
            this.OrderTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderTableTableAdapter = new BriteSparxCafeSystem.GroupWst17DataSetTableAdapters.OrderTableTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupWst17DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // Report
            // 
            this.Report.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrderTableBindingSource;
            this.Report.LocalReport.DataSources.Add(reportDataSource1);
            this.Report.LocalReport.ReportEmbeddedResource = "BriteSparxCafeSystem.DatabaseReport.rdlc";
            this.Report.Location = new System.Drawing.Point(0, 24);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(1016, 401);
            this.Report.TabIndex = 1;
            this.Report.Visible = false;
            // 
            // GroupWst17DataSet
            // 
            this.GroupWst17DataSet.DataSetName = "GroupWst17DataSet";
            this.GroupWst17DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrderTableBindingSource
            // 
            this.OrderTableBindingSource.DataMember = "OrderTable";
            this.OrderTableBindingSource.DataSource = this.GroupWst17DataSet;
            // 
            // OrderTableTableAdapter
            // 
            this.OrderTableTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 425);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupWst17DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer Report;
        private System.Windows.Forms.BindingSource OrderTableBindingSource;
        private GroupWst17DataSet GroupWst17DataSet;
        private GroupWst17DataSetTableAdapters.OrderTableTableAdapter OrderTableTableAdapter;
    }
}