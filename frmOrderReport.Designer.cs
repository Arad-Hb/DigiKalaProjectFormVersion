namespace DigiKalaProject
{
    partial class frmOrderReport
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
            this.grdOrderReport = new System.Windows.Forms.DataGridView();
            this.clmnOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrderItems = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.DatePickerToDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.DatePickerFromDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdOrderReport
            // 
            this.grdOrderReport.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.grdOrderReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnOrderID,
            this.clmnOrderDate,
            this.clmnCustomerName,
            this.clmnEmployeeName,
            this.clmnTotalPrice,
            this.clmnTax,
            this.btnOrderItems});
            this.grdOrderReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.grdOrderReport.Location = new System.Drawing.Point(427, 0);
            this.grdOrderReport.Name = "grdOrderReport";
            this.grdOrderReport.RowHeadersWidth = 51;
            this.grdOrderReport.RowTemplate.Height = 24;
            this.grdOrderReport.Size = new System.Drawing.Size(930, 723);
            this.grdOrderReport.TabIndex = 0;
            this.grdOrderReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderReport_CellContentClick);
            // 
            // clmnOrderID
            // 
            this.clmnOrderID.DataPropertyName = "OrderID";
            this.clmnOrderID.HeaderText = "شماره فاکتور";
            this.clmnOrderID.MinimumWidth = 6;
            this.clmnOrderID.Name = "clmnOrderID";
            this.clmnOrderID.ToolTipText = "شماره فاکتور";
            this.clmnOrderID.Width = 125;
            // 
            // clmnOrderDate
            // 
            this.clmnOrderDate.DataPropertyName = "OrderDate";
            this.clmnOrderDate.HeaderText = "تاریخ";
            this.clmnOrderDate.MinimumWidth = 6;
            this.clmnOrderDate.Name = "clmnOrderDate";
            this.clmnOrderDate.ToolTipText = "تاریخ";
            this.clmnOrderDate.Width = 125;
            // 
            // clmnCustomerName
            // 
            this.clmnCustomerName.DataPropertyName = "CustomerName";
            this.clmnCustomerName.HeaderText = "نام مشتری";
            this.clmnCustomerName.MinimumWidth = 6;
            this.clmnCustomerName.Name = "clmnCustomerName";
            this.clmnCustomerName.ToolTipText = "نام مشتری";
            this.clmnCustomerName.Width = 125;
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.DataPropertyName = "EmployeeName";
            this.clmnEmployeeName.HeaderText = "نام کارمند";
            this.clmnEmployeeName.MinimumWidth = 6;
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            this.clmnEmployeeName.ToolTipText = "نام کارمند";
            this.clmnEmployeeName.Width = 125;
            // 
            // clmnTotalPrice
            // 
            this.clmnTotalPrice.DataPropertyName = "TotalPrice";
            this.clmnTotalPrice.HeaderText = "مبلغ فاکتور";
            this.clmnTotalPrice.MinimumWidth = 6;
            this.clmnTotalPrice.Name = "clmnTotalPrice";
            this.clmnTotalPrice.ToolTipText = "مبلغ فاکتور";
            this.clmnTotalPrice.Width = 125;
            // 
            // clmnTax
            // 
            this.clmnTax.DataPropertyName = "Tax";
            this.clmnTax.HeaderText = "مالیات";
            this.clmnTax.MinimumWidth = 6;
            this.clmnTax.Name = "clmnTax";
            this.clmnTax.ToolTipText = "مالیات";
            this.clmnTax.Width = 125;
            // 
            // btnOrderItems
            // 
            this.btnOrderItems.HeaderText = "جزییات";
            this.btnOrderItems.MinimumWidth = 6;
            this.btnOrderItems.Name = "btnOrderItems";
            this.btnOrderItems.Text = "جزییات";
            this.btnOrderItems.UseColumnTextForButtonValue = true;
            this.btnOrderItems.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.lblDateTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.DatePickerToDate);
            this.groupBox1.Controls.Add(this.DatePickerFromDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 723);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جو بر اساس";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDateTime.Location = new System.Drawing.Point(172, 18);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDateTime.Size = new System.Drawing.Size(88, 25);
            this.lblDateTime.TabIndex = 14;
            this.lblDateTime.Text = "تاریخ امروز";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(256, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "کد اشتراک";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(238, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "شماره فاکتور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(252, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "تاریخ پایان";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Turquoise;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowAll.Location = new System.Drawing.Point(72, 443);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(268, 49);
            this.btnShowAll.TabIndex = 10;
            this.btnShowAll.Text = "گزارش کلی";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Turquoise;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(72, 367);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(268, 49);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "گزارش موارد مورد جستو جو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(92, 297);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerID.TabIndex = 6;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(92, 226);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 22);
            this.txtOrderID.TabIndex = 5;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // DatePickerToDate
            // 
            this.DatePickerToDate.Location = new System.Drawing.Point(72, 153);
            this.DatePickerToDate.Name = "DatePickerToDate";
            this.DatePickerToDate.Size = new System.Drawing.Size(120, 20);
            this.DatePickerToDate.TabIndex = 4;
            this.DatePickerToDate.SelectedDateTimeChanged += new System.EventHandler(this.DatePickerToDate_SelectedDateTimeChanged);
            // 
            // DatePickerFromDate
            // 
            this.DatePickerFromDate.Location = new System.Drawing.Point(72, 85);
            this.DatePickerFromDate.Name = "DatePickerFromDate";
            this.DatePickerFromDate.Size = new System.Drawing.Size(120, 20);
            this.DatePickerFromDate.TabIndex = 2;
            this.DatePickerFromDate.SelectedDateTimeChanged += new System.EventHandler(this.DatePickerFromDate_SelectedDateTimeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(245, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ شروع";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 723);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdOrderReport);
            this.Name = "frmOrderReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فرم گزارش فروش";
            this.Load += new System.EventHandler(this.frmOrderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrderReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTax;
        private System.Windows.Forms.DataGridViewButtonColumn btnOrderItems;
        private FarsiLibrary.Win.Controls.FADatePicker DatePickerFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtOrderID;
        private FarsiLibrary.Win.Controls.FADatePicker DatePickerToDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}