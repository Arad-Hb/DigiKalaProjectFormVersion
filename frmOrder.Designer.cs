namespace DigiKalaProject
{
    partial class frmOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescribtion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.faDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.grpbOrderDetails = new System.Windows.Forms.GroupBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nmrQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.clmnOrderItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblService = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSumTotalPrice = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpbOrderDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " مشتری";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(201, 114);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(417, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lstCustomer
            // 
            this.lstCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 25;
            this.lstCustomer.Location = new System.Drawing.Point(201, 136);
            this.lstCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(417, 100);
            this.lstCustomer.TabIndex = 2;
            this.lstCustomer.Visible = false;
            this.lstCustomer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCustomer_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Controls.Add(this.lblMobile);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(18, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سر برگ فاکتور";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(68, 47);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(110, 25);
            this.lblOrderID.TabIndex = 6;
            this.lblOrderID.Text = "شماره فاکتور";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(235, 47);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(110, 25);
            this.lblMobile.TabIndex = 4;
            this.lblMobile.Text = "شماره موبایل";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(401, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام خانوادگی";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(513, 47);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(38, 25);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "نام ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(201, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "ثبت فاکتور";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(13, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "توضیحات";
            // 
            // txtDescribtion
            // 
            this.txtDescribtion.Location = new System.Drawing.Point(201, 309);
            this.txtDescribtion.Multiline = true;
            this.txtDescribtion.Name = "txtDescribtion";
            this.txtDescribtion.Size = new System.Drawing.Size(417, 110);
            this.txtDescribtion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(13, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "تاریخ";
            // 
            // faDatePicker
            // 
            this.faDatePicker.Location = new System.Drawing.Point(201, 258);
            this.faDatePicker.Name = "faDatePicker";
            this.faDatePicker.SelectedDateTime = new System.DateTime(2024, 1, 4, 0, 0, 0, 0);
            this.faDatePicker.Size = new System.Drawing.Size(417, 25);
            this.faDatePicker.TabIndex = 11;
            // 
            // grpbOrderDetails
            // 
            this.grpbOrderDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.grpbOrderDetails.Controls.Add(this.lblSumTotalPrice);
            this.grpbOrderDetails.Controls.Add(this.label16);
            this.grpbOrderDetails.Controls.Add(this.lblTax);
            this.grpbOrderDetails.Controls.Add(this.label14);
            this.grpbOrderDetails.Controls.Add(this.lblService);
            this.grpbOrderDetails.Controls.Add(this.label12);
            this.grpbOrderDetails.Controls.Add(this.lblTotalPayment);
            this.grpbOrderDetails.Controls.Add(this.lblPayment);
            this.grpbOrderDetails.Controls.Add(this.label9);
            this.grpbOrderDetails.Controls.Add(this.btnAddNew);
            this.grpbOrderDetails.Controls.Add(this.panel1);
            this.grpbOrderDetails.Controls.Add(this.label5);
            this.grpbOrderDetails.Controls.Add(this.cmbCategories);
            this.grpbOrderDetails.Controls.Add(this.label4);
            this.grpbOrderDetails.Controls.Add(this.cmbProducts);
            this.grpbOrderDetails.Enabled = false;
            this.grpbOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbOrderDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbOrderDetails.Location = new System.Drawing.Point(679, -4);
            this.grpbOrderDetails.Name = "grpbOrderDetails";
            this.grpbOrderDetails.Size = new System.Drawing.Size(692, 662);
            this.grpbOrderDetails.TabIndex = 12;
            this.grpbOrderDetails.TabStop = false;
            this.grpbOrderDetails.Text = "اقلام سفارش";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(35, 610);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(24, 25);
            this.lblTotalPayment.TabIndex = 12;
            this.lblTotalPayment.Text = "0";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(-34, 561);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(0, 25);
            this.lblPayment.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "مالیات 10% :";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddNew.Location = new System.Drawing.Point(136, 475);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(417, 60);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "افزودن به سفارش";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.nmrQuantity);
            this.panel1.Controls.Add(this.lblUnitPrice);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(2, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 257);
            this.panel1.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Turquoise;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCancel.Location = new System.Drawing.Point(10, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 42);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.Location = new System.Drawing.Point(10, 48);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 42);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "ثبت";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // nmrQuantity
            // 
            this.nmrQuantity.Location = new System.Drawing.Point(233, 140);
            this.nmrQuantity.Name = "nmrQuantity";
            this.nmrQuantity.Size = new System.Drawing.Size(88, 30);
            this.nmrQuantity.TabIndex = 15;
            this.nmrQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrQuantity.ValueChanged += new System.EventHandler(this.nmrQuantity_ValueChanged);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(242, 83);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(0, 25);
            this.lblUnitPrice.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "قیمت محصول : ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(233, 203);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 25);
            this.lblTotalPrice.TabIndex = 12;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(242, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(0, 25);
            this.lblProductName.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "تعداد محصول : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "مبلغ کل :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "نام محصول : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "دسته بندی";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(391, 90);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(279, 33);
            this.cmbCategories.TabIndex = 6;
            this.cmbCategories.Text = "دسته بندی را انتخاب کنید";
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "محصولات";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(35, 90);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(279, 33);
            this.cmbProducts.TabIndex = 0;
            this.cmbProducts.Text = "محصول را انتخاب کنید";
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // grdOrders
            // 
            this.grdOrders.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.grdOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnOrderItemID,
            this.clmnOrderID,
            this.clmnProductID,
            this.clmnProductName,
            this.clmnBasePrice,
            this.clmnQuantity,
            this.clmnTotalPrice,
            this.btnEdit,
            this.btnDelete});
            this.grdOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdOrders.Location = new System.Drawing.Point(0, 658);
            this.grdOrders.MultiSelect = false;
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.RowHeadersWidth = 51;
            this.grdOrders.RowTemplate.Height = 24;
            this.grdOrders.Size = new System.Drawing.Size(1369, 103);
            this.grdOrders.TabIndex = 13;
            this.grdOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellContentClick);
            // 
            // clmnOrderItemID
            // 
            this.clmnOrderItemID.DataPropertyName = "OrderItemID";
            this.clmnOrderItemID.HeaderText = "شناسه اقلام سفارش";
            this.clmnOrderItemID.MinimumWidth = 6;
            this.clmnOrderItemID.Name = "clmnOrderItemID";
            this.clmnOrderItemID.ToolTipText = "شناسه اقلام سفارش";
            this.clmnOrderItemID.Visible = false;
            this.clmnOrderItemID.Width = 125;
            // 
            // clmnOrderID
            // 
            this.clmnOrderID.DataPropertyName = "OrderID";
            this.clmnOrderID.HeaderText = "شماره فاکتور";
            this.clmnOrderID.MinimumWidth = 6;
            this.clmnOrderID.Name = "clmnOrderID";
            this.clmnOrderID.ToolTipText = "شماره فاکتور";
            this.clmnOrderID.Width = 165;
            // 
            // clmnProductID
            // 
            this.clmnProductID.DataPropertyName = "ProductID";
            this.clmnProductID.HeaderText = "شناسه محصول";
            this.clmnProductID.MinimumWidth = 6;
            this.clmnProductID.Name = "clmnProductID";
            this.clmnProductID.ToolTipText = "شناسه محصول";
            this.clmnProductID.Width = 165;
            // 
            // clmnProductName
            // 
            this.clmnProductName.DataPropertyName = "ProductName";
            this.clmnProductName.HeaderText = "نام محصول";
            this.clmnProductName.MinimumWidth = 6;
            this.clmnProductName.Name = "clmnProductName";
            this.clmnProductName.ToolTipText = "نام محصول";
            this.clmnProductName.Width = 165;
            // 
            // clmnBasePrice
            // 
            this.clmnBasePrice.DataPropertyName = "UnitPrice";
            this.clmnBasePrice.HeaderText = "قیمت";
            this.clmnBasePrice.MinimumWidth = 6;
            this.clmnBasePrice.Name = "clmnBasePrice";
            this.clmnBasePrice.ToolTipText = "قیمت";
            this.clmnBasePrice.Width = 165;
            // 
            // clmnQuantity
            // 
            this.clmnQuantity.DataPropertyName = "Quantity";
            this.clmnQuantity.HeaderText = "تعداد";
            this.clmnQuantity.MinimumWidth = 6;
            this.clmnQuantity.Name = "clmnQuantity";
            this.clmnQuantity.ToolTipText = "تعداد";
            this.clmnQuantity.Width = 165;
            // 
            // clmnTotalPrice
            // 
            this.clmnTotalPrice.DataPropertyName = "TotalPrice";
            this.clmnTotalPrice.HeaderText = "قیمت نهایی";
            this.clmnTotalPrice.MinimumWidth = 6;
            this.clmnTotalPrice.Name = "clmnTotalPrice";
            this.clmnTotalPrice.ToolTipText = "قیمت نهایی";
            this.clmnTotalPrice.Width = 165;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "ویرایش";
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseColumnTextForButtonValue = true;
            this.btnEdit.Width = 165;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "حذف";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 165;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(372, 610);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(24, 25);
            this.lblService.TabIndex = 14;
            this.lblService.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 610);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "بسته بندی و ارسال 5%  :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(372, 561);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(24, 25);
            this.lblTax.TabIndex = 16;
            this.lblTax.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(159, 610);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "مبلغ قابل پرداخت  :";
            // 
            // lblSumTotalPrice
            // 
            this.lblSumTotalPrice.AutoSize = true;
            this.lblSumTotalPrice.Location = new System.Drawing.Point(35, 561);
            this.lblSumTotalPrice.Name = "lblSumTotalPrice";
            this.lblSumTotalPrice.Size = new System.Drawing.Size(24, 25);
            this.lblSumTotalPrice.TabIndex = 18;
            this.lblSumTotalPrice.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(139, 561);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "جمع کل اقلام فاکتور  :";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1369, 761);
            this.Controls.Add(this.grdOrders);
            this.Controls.Add(this.grpbOrderDetails);
            this.Controls.Add(this.faDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescribtion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فرم ثبت سفارش";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbOrderDetails.ResumeLayout(false);
            this.grpbOrderDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescribtion;
        private System.Windows.Forms.Label label3;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker;
        private System.Windows.Forms.GroupBox grpbOrderDetails;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.NumericUpDown nmrQuantity;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOrderItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblSumTotalPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label label12;
    }
}