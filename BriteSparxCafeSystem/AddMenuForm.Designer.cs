namespace BriteSparxCafeSystem
{
    partial class AddMenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAddMenu = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds1 = new BriteSparxCafeSystem.GroupWst17DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvMenuUpdated = new System.Windows.Forms.DataGridView();
            this.menuIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qOHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuUpdatedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateQOHtextBox = new System.Windows.Forms.TextBox();
            this.searchMenuTextbox = new System.Windows.Forms.TextBox();
            this.updateQOHbutton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.MenuDescripTextbox = new System.Windows.Forms.TextBox();
            this.categorycomboBox = new System.Windows.Forms.ComboBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Archivebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.menuIDtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MenuPricetextBox = new System.Windows.Forms.TextBox();
            this.QOHtextBox = new System.Windows.Forms.TextBox();
            this.MenuNametextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taMenu1 = new BriteSparxCafeSystem.GroupWst17DataSetTableAdapters.MenuTableAdapter();
            this.taMenu2 = new BriteSparxCafeSystem.GroupWst17DataSetTableAdapters.MenuTableAdapter();
            this.taOrderItem = new BriteSparxCafeSystem.GroupWst17DataSetTableAdapters.OrderItemTableAdapter();
            this.menuUpdatedTableAdapter = new BriteSparxCafeSystem.GroupWst17DataSetTableAdapters.MenuUpdatedTableAdapter();
            this.sales_MenuTableAdapter = new BriteSparxCafeSystem.GroupWst17DataSetTableAdapters.Sales_MenuTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tpAddMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuUpdatedBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAddMenu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1924, 1055);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAddMenu
            // 
            this.tpAddMenu.BackColor = System.Drawing.Color.Gold;
            this.tpAddMenu.Controls.Add(this.groupBox2);
            this.tpAddMenu.Controls.Add(this.groupBox1);
            this.tpAddMenu.Controls.Add(this.panel5);
            this.tpAddMenu.Controls.Add(this.panel2);
            this.tpAddMenu.Location = new System.Drawing.Point(4, 37);
            this.tpAddMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAddMenu.Name = "tpAddMenu";
            this.tpAddMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAddMenu.Size = new System.Drawing.Size(1916, 1014);
            this.tpAddMenu.TabIndex = 0;
            this.tpAddMenu.Text = "Add Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(977, 579);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(950, 356);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.MenuName,
            this.priceDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesMenuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 300);
            this.dataGridView1.TabIndex = 52;
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
            // MenuName
            // 
            this.MenuName.DataPropertyName = "MenuName";
            this.MenuName.HeaderText = "MenuName";
            this.MenuName.MinimumWidth = 6;
            this.MenuName.Name = "MenuName";
            this.MenuName.ReadOnly = true;
            this.MenuName.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.priceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesMenuBindingSource
            // 
            this.salesMenuBindingSource.DataMember = "Sales_Menu";
            this.salesMenuBindingSource.DataSource = this.ds1;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "GroupWst17DataSet";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvMenuUpdated);
            this.groupBox1.Controls.Add(this.updateQOHtextBox);
            this.groupBox1.Controls.Add(this.searchMenuTextbox);
            this.groupBox1.Controls.Add(this.updateQOHbutton);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(978, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 409);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menus";
            // 
            // gvMenuUpdated
            // 
            this.gvMenuUpdated.AutoGenerateColumns = false;
            this.gvMenuUpdated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMenuUpdated.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn2,
            this.CategoryName,
            this.menuNameDataGridViewTextBoxColumn,
            this.Description,
            this.priceDataGridViewTextBoxColumn2,
            this.qOHDataGridViewTextBoxColumn});
            this.gvMenuUpdated.DataSource = this.menuUpdatedBindingSource;
            this.gvMenuUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMenuUpdated.Location = new System.Drawing.Point(3, 30);
            this.gvMenuUpdated.Name = "gvMenuUpdated";
            this.gvMenuUpdated.RowHeadersWidth = 51;
            this.gvMenuUpdated.RowTemplate.Height = 24;
            this.gvMenuUpdated.Size = new System.Drawing.Size(929, 376);
            this.gvMenuUpdated.TabIndex = 1;
            this.gvMenuUpdated.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvMenuUpdated_RowHeaderMouseClick);
            this.gvMenuUpdated.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvMenuUpdated_RowHeaderMouseDoubleClick);
            // 
            // menuIDDataGridViewTextBoxColumn2
            // 
            this.menuIDDataGridViewTextBoxColumn2.DataPropertyName = "MenuID";
            this.menuIDDataGridViewTextBoxColumn2.HeaderText = "MenuID";
            this.menuIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.menuIDDataGridViewTextBoxColumn2.Name = "menuIDDataGridViewTextBoxColumn2";
            this.menuIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.menuIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 125;
            // 
            // menuNameDataGridViewTextBoxColumn
            // 
            this.menuNameDataGridViewTextBoxColumn.DataPropertyName = "MenuName";
            this.menuNameDataGridViewTextBoxColumn.HeaderText = "MenuName";
            this.menuNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menuNameDataGridViewTextBoxColumn.Name = "menuNameDataGridViewTextBoxColumn";
            this.menuNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn2
            // 
            this.priceDataGridViewTextBoxColumn2.DataPropertyName = "price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.priceDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceDataGridViewTextBoxColumn2.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
            this.priceDataGridViewTextBoxColumn2.Width = 125;
            // 
            // qOHDataGridViewTextBoxColumn
            // 
            this.qOHDataGridViewTextBoxColumn.DataPropertyName = "QOH";
            this.qOHDataGridViewTextBoxColumn.HeaderText = "QOH";
            this.qOHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qOHDataGridViewTextBoxColumn.Name = "qOHDataGridViewTextBoxColumn";
            this.qOHDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuUpdatedBindingSource
            // 
            this.menuUpdatedBindingSource.DataMember = "MenuUpdated";
            this.menuUpdatedBindingSource.DataSource = this.ds1;
            // 
            // updateQOHtextBox
            // 
            this.updateQOHtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQOHtextBox.Location = new System.Drawing.Point(266, 351);
            this.updateQOHtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateQOHtextBox.Multiline = true;
            this.updateQOHtextBox.Name = "updateQOHtextBox";
            this.updateQOHtextBox.Size = new System.Drawing.Size(211, 45);
            this.updateQOHtextBox.TabIndex = 61;
            // 
            // searchMenuTextbox
            // 
            this.searchMenuTextbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMenuTextbox.Location = new System.Drawing.Point(17, 64);
            this.searchMenuTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchMenuTextbox.Name = "searchMenuTextbox";
            this.searchMenuTextbox.Size = new System.Drawing.Size(459, 47);
            this.searchMenuTextbox.TabIndex = 50;
            this.searchMenuTextbox.TextChanged += new System.EventHandler(this.searchMenuTextbox_TextChanged);
            // 
            // updateQOHbutton
            // 
            this.updateQOHbutton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQOHbutton.Location = new System.Drawing.Point(17, 351);
            this.updateQOHbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateQOHbutton.Name = "updateQOHbutton";
            this.updateQOHbutton.Size = new System.Drawing.Size(243, 46);
            this.updateQOHbutton.TabIndex = 61;
            this.updateQOHbutton.Text = "Update QOH";
            this.updateQOHbutton.UseVisualStyleBackColor = true;
            this.updateQOHbutton.Click += new System.EventHandler(this.updateQOHbutton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 32);
            this.label14.TabIndex = 49;
            this.label14.Text = "Enter Menu Name:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.pictureBox7);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pictureBox12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1910, 165);
            this.panel5.TabIndex = 48;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox7.Image = global::BriteSparxCafeSystem.Properties.Resources.Logo1;
            this.pictureBox7.Location = new System.Drawing.Point(1563, 0);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(347, 165);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(427, 17);
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
            this.pictureBox12.Size = new System.Drawing.Size(347, 165);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 9;
            this.pictureBox12.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.MenuDescripTextbox);
            this.panel2.Controls.Add(this.categorycomboBox);
            this.panel2.Controls.Add(this.Exitbutton);
            this.panel2.Controls.Add(this.Clearbutton);
            this.panel2.Controls.Add(this.Searchbutton);
            this.panel2.Controls.Add(this.Archivebutton);
            this.panel2.Controls.Add(this.Updatebutton);
            this.panel2.Controls.Add(this.menuIDtextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.MenuPricetextBox);
            this.panel2.Controls.Add(this.QOHtextBox);
            this.panel2.Controls.Add(this.MenuNametextBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Addbutton);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 707);
            this.panel2.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 36);
            this.label7.TabIndex = 63;
            this.label7.Text = "Description:";
            // 
            // MenuDescripTextbox
            // 
            this.MenuDescripTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDescripTextbox.Location = new System.Drawing.Point(365, 325);
            this.MenuDescripTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuDescripTextbox.Multiline = true;
            this.MenuDescripTextbox.Name = "MenuDescripTextbox";
            this.MenuDescripTextbox.Size = new System.Drawing.Size(501, 43);
            this.MenuDescripTextbox.TabIndex = 62;
            // 
            // categorycomboBox
            // 
            this.categorycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycomboBox.FormattingEnabled = true;
            this.categorycomboBox.Items.AddRange(new object[] {
            "MEALS",
            "DRINKS",
            "SPECIALTIES",
            "SANDWICHES",
            "SNACKS",
            "DESSERTS"});
            this.categorycomboBox.Location = new System.Drawing.Point(366, 196);
            this.categorycomboBox.Name = "categorycomboBox";
            this.categorycomboBox.Size = new System.Drawing.Size(500, 44);
            this.categorycomboBox.TabIndex = 61;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(621, 615);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(245, 53);
            this.Exitbutton.TabIndex = 60;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.Location = new System.Drawing.Point(340, 615);
            this.Clearbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(245, 53);
            this.Clearbutton.TabIndex = 59;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Location = new System.Drawing.Point(50, 615);
            this.Searchbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(245, 53);
            this.Searchbutton.TabIndex = 58;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Archivebutton
            // 
            this.Archivebutton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Archivebutton.Location = new System.Drawing.Point(620, 548);
            this.Archivebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Archivebutton.Name = "Archivebutton";
            this.Archivebutton.Size = new System.Drawing.Size(245, 53);
            this.Archivebutton.TabIndex = 57;
            this.Archivebutton.Text = "Archive";
            this.Archivebutton.UseVisualStyleBackColor = true;
            this.Archivebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(331, 548);
            this.Updatebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(245, 53);
            this.Updatebutton.TabIndex = 56;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // menuIDtextBox
            // 
            this.menuIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuIDtextBox.Location = new System.Drawing.Point(365, 135);
            this.menuIDtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuIDtextBox.Multiline = true;
            this.menuIDtextBox.Name = "menuIDtextBox";
            this.menuIDtextBox.Size = new System.Drawing.Size(501, 43);
            this.menuIDtextBox.TabIndex = 55;
            this.menuIDtextBox.TextChanged += new System.EventHandler(this.menuIDtextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 36);
            this.label8.TabIndex = 54;
            this.label8.Text = "MenuID:";
            // 
            // MenuPricetextBox
            // 
            this.MenuPricetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPricetextBox.Location = new System.Drawing.Point(366, 382);
            this.MenuPricetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPricetextBox.Multiline = true;
            this.MenuPricetextBox.Name = "MenuPricetextBox";
            this.MenuPricetextBox.Size = new System.Drawing.Size(501, 43);
            this.MenuPricetextBox.TabIndex = 51;
            this.MenuPricetextBox.TextChanged += new System.EventHandler(this.MenuPricetextBox_TextChanged);
            // 
            // QOHtextBox
            // 
            this.QOHtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QOHtextBox.Location = new System.Drawing.Point(366, 453);
            this.QOHtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QOHtextBox.Multiline = true;
            this.QOHtextBox.Name = "QOHtextBox";
            this.QOHtextBox.Size = new System.Drawing.Size(501, 43);
            this.QOHtextBox.TabIndex = 50;
            // 
            // MenuNametextBox
            // 
            this.MenuNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuNametextBox.Location = new System.Drawing.Point(366, 266);
            this.MenuNametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuNametextBox.Multiline = true;
            this.MenuNametextBox.Name = "MenuNametextBox";
            this.MenuNametextBox.Size = new System.Drawing.Size(501, 43);
            this.MenuNametextBox.TabIndex = 49;
            this.MenuNametextBox.TextChanged += new System.EventHandler(this.MenuNametextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(79, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(622, 36);
            this.label11.TabIndex = 47;
            this.label11.Text = "Please enter the following details to add menu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(347, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 39);
            this.label10.TabIndex = 46;
            this.label10.Text = "Menu Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 615);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 36);
            this.label6.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 36);
            this.label5.TabIndex = 33;
            this.label5.Text = "QOH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Category:";
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(50, 548);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(245, 53);
            this.Addbutton.TabIndex = 27;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-61, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = " ";
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataMember = "OrderItem";
            this.orderItemBindingSource.DataSource = this.ds1;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.ds1;
            // 
            // taMenu1
            // 
            this.taMenu1.ClearBeforeFill = true;
            // 
            // taMenu2
            // 
            this.taMenu2.ClearBeforeFill = true;
            // 
            // taOrderItem
            // 
            this.taOrderItem.ClearBeforeFill = true;
            // 
            // menuUpdatedTableAdapter
            // 
            this.menuUpdatedTableAdapter.ClearBeforeFill = true;
            // 
            // sales_MenuTableAdapter
            // 
            this.sales_MenuTableAdapter.ClearBeforeFill = true;
            // 
            // AddMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddMenuForm";
            this.Text = "AddMenuForm";
            this.Load += new System.EventHandler(this.AddMenuForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAddMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuUpdatedBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAddMenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Archivebutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.TextBox menuIDtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MenuPricetextBox;
        private System.Windows.Forms.TextBox QOHtextBox;
        private System.Windows.Forms.TextBox MenuNametextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox searchMenuTextbox;
        private System.Windows.Forms.Label label14;
        private GroupWst17DataSet ds1;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private GroupWst17DataSetTableAdapters.MenuTableAdapter taMenu1;
        private GroupWst17DataSetTableAdapters.MenuTableAdapter taMenu2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private GroupWst17DataSetTableAdapters.OrderItemTableAdapter taOrderItem;
        private System.Windows.Forms.Button updateQOHbutton;
        private System.Windows.Forms.TextBox updateQOHtextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox categorycomboBox;
        private System.Windows.Forms.BindingSource menuUpdatedBindingSource;
        private GroupWst17DataSetTableAdapters.MenuUpdatedTableAdapter menuUpdatedTableAdapter;
        private System.Windows.Forms.BindingSource salesMenuBindingSource;
        private GroupWst17DataSetTableAdapters.Sales_MenuTableAdapter sales_MenuTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MenuDescripTextbox;
        private System.Windows.Forms.DataGridView gvMenuUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qOHDataGridViewTextBoxColumn;
    }
}