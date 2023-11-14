namespace BriteSparxCafeSystem
{
    partial class Delivery
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deliveryCustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds1 = new BriteSparxCafeSystem.GroupWst17DataSet();
            this.ExitButton = new System.Windows.Forms.Button();
            this.updateOSbutton = new System.Windows.Forms.Button();
            this.updateOScomboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst17DataSet1 = new BriteSparxCafeSystem.GroupWst17DataSet1();
            this.taCustomer1 = new BriteSparxCafeSystem.GroupWst17DataSet1TableAdapters.CustomerTableAdapter();
            this.orderTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taOrder1 = new BriteSparxCafeSystem.GroupWst17DataSetTableAdapters.OrderTableTableAdapter();
            this.delivery_CustTableAdapter = new BriteSparxCafeSystem.GroupWst17DataSetTableAdapters.Delivery_CustTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deliveryCustBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverypointnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryCustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst17DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryCustBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1924, 1035);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gold;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.ExitButton);
            this.tabPage1.Controls.Add(this.updateOSbutton);
            this.tabPage1.Controls.Add(this.updateOScomboBox);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1916, 994);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Assigned Deliveries";
            // 
            // deliveryCustBindingSource
            // 
            this.deliveryCustBindingSource.DataMember = "Delivery_Cust";
            this.deliveryCustBindingSource.DataSource = this.ds1;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "GroupWst17DataSet";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(868, 632);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 49);
            this.ExitButton.TabIndex = 83;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // updateOSbutton
            // 
            this.updateOSbutton.BackColor = System.Drawing.Color.White;
            this.updateOSbutton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOSbutton.Location = new System.Drawing.Point(486, 631);
            this.updateOSbutton.Margin = new System.Windows.Forms.Padding(4);
            this.updateOSbutton.Name = "updateOSbutton";
            this.updateOSbutton.Size = new System.Drawing.Size(369, 50);
            this.updateOSbutton.TabIndex = 77;
            this.updateOSbutton.Text = "Update Order Status";
            this.updateOSbutton.UseVisualStyleBackColor = false;
            this.updateOSbutton.Click += new System.EventHandler(this.updateOSbutton_Click_1);
            // 
            // updateOScomboBox
            // 
            this.updateOScomboBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOScomboBox.FormattingEnabled = true;
            this.updateOScomboBox.Items.AddRange(new object[] {
            "Delivered"});
            this.updateOScomboBox.Location = new System.Drawing.Point(9, 632);
            this.updateOScomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.updateOScomboBox.Name = "updateOScomboBox";
            this.updateOScomboBox.Size = new System.Drawing.Size(460, 49);
            this.updateOScomboBox.TabIndex = 78;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.pictureBox7);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pictureBox12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1910, 183);
            this.panel5.TabIndex = 75;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox7.Image = global::BriteSparxCafeSystem.Properties.Resources.Logo1;
            this.pictureBox7.Location = new System.Drawing.Point(1563, 0);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(347, 183);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(447, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1027, 127);
            this.label3.TabIndex = 10;
            this.label3.Text = "BRITE SPARX CAFE";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox12.Image = global::BriteSparxCafeSystem.Properties.Resources.Logo1;
            this.pictureBox12.Location = new System.Drawing.Point(0, 0);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(347, 183);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 9;
            this.pictureBox12.TabStop = false;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.groupWst17DataSet1;
            // 
            // groupWst17DataSet1
            // 
            this.groupWst17DataSet1.DataSetName = "GroupWst17DataSet1";
            this.groupWst17DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taCustomer1
            // 
            this.taCustomer1.ClearBeforeFill = true;
            // 
            // orderTableBindingSource
            // 
            this.orderTableBindingSource.DataMember = "OrderTable";
            this.orderTableBindingSource.DataSource = this.ds1;
            // 
            // taOrder1
            // 
            this.taOrder1.ClearBeforeFill = true;
            // 
            // delivery_CustTableAdapter
            // 
            this.delivery_CustTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.deliverypointnameDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn,
            this.orderstatusDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliveryCustBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(52, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(978, 186);
            this.dataGridView1.TabIndex = 84;
            // 
            // deliveryCustBindingSource1
            // 
            this.deliveryCustBindingSource1.DataMember = "Delivery_Cust";
            this.deliveryCustBindingSource1.DataSource = this.ds1;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "order_ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "CustName";
            this.custNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.custNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliverypointnameDataGridViewTextBoxColumn
            // 
            this.deliverypointnameDataGridViewTextBoxColumn.DataPropertyName = "delivery_point_name";
            this.deliverypointnameDataGridViewTextBoxColumn.HeaderText = "delivery_point_name";
            this.deliverypointnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliverypointnameDataGridViewTextBoxColumn.Name = "deliverypointnameDataGridViewTextBoxColumn";
            this.deliverypointnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            this.totalamountDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderstatusDataGridViewTextBoxColumn
            // 
            this.orderstatusDataGridViewTextBoxColumn.DataPropertyName = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.HeaderText = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderstatusDataGridViewTextBoxColumn.Name = "orderstatusDataGridViewTextBoxColumn";
            this.orderstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1035);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryCustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst17DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryCustBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupWst17DataSet ds1;
        private System.Windows.Forms.BindingSource orderTableBindingSource;
        private GroupWst17DataSetTableAdapters.OrderTableTableAdapter taOrder1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button updateOSbutton;
        private System.Windows.Forms.ComboBox updateOScomboBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Button ExitButton;
        private GroupWst17DataSet1 groupWst17DataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private GroupWst17DataSet1TableAdapters.CustomerTableAdapter taCustomer1;
        private System.Windows.Forms.BindingSource deliveryCustBindingSource;
        private GroupWst17DataSetTableAdapters.Delivery_CustTableAdapter delivery_CustTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverypointnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deliveryCustBindingSource1;
    }
}