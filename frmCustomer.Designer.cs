namespace DigiKalaProject
{
    partial class frmCustomer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDisactive = new System.Windows.Forms.RadioButton();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.clmnCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(1076, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(198, 42);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Location = new System.Drawing.Point(1076, 110);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(198, 42);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddNew.Location = new System.Drawing.Point(1076, 33);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(198, 42);
            this.btnAddNew.TabIndex = 54;
            this.btnAddNew.Text = "ثبت";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.rdbDisactive);
            this.groupBox1.Controls.Add(this.rdbActive);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(27, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 106);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وضعیت فعالیت";
            // 
            // rdbDisactive
            // 
            this.rdbDisactive.AutoSize = true;
            this.rdbDisactive.ForeColor = System.Drawing.SystemColors.Window;
            this.rdbDisactive.Location = new System.Drawing.Point(35, 38);
            this.rdbDisactive.Name = "rdbDisactive";
            this.rdbDisactive.Size = new System.Drawing.Size(100, 29);
            this.rdbDisactive.TabIndex = 3;
            this.rdbDisactive.TabStop = true;
            this.rdbDisactive.Text = "غیر فعال";
            this.rdbDisactive.UseVisualStyleBackColor = true;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.ForeColor = System.Drawing.SystemColors.Window;
            this.rdbActive.Location = new System.Drawing.Point(222, 38);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(65, 29);
            this.rdbActive.TabIndex = 1;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "فعال";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(623, 184);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(372, 166);
            this.txtAddress.TabIndex = 52;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(623, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(372, 30);
            this.txtEmail.TabIndex = 51;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(623, 33);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(372, 30);
            this.txtMobile.TabIndex = 50;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(146, 224);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(336, 30);
            this.txtPassword.TabIndex = 49;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(146, 160);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(336, 30);
            this.txtUserName.TabIndex = 48;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(146, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(336, 30);
            this.txtLastName.TabIndex = 47;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(146, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(336, 30);
            this.txtFirstName.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(543, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "آدرس";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(543, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "ایمیل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(543, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "موبایل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(40, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "رمز ورود";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(40, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "کلمه عبور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(40, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "نام";
            // 
            // grdCustomer
            // 
            this.grdCustomer.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.grdCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCustomerID,
            this.clmnUserID,
            this.clmnFirstName,
            this.clmnLastName,
            this.clmnUserName,
            this.clmnPassword,
            this.clmnMobile,
            this.clmnEmail,
            this.clmnAddress,
            this.clmnIsActive,
            this.clmnDelete,
            this.clmnUpdate});
            this.grdCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdCustomer.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grdCustomer.Location = new System.Drawing.Point(0, 417);
            this.grdCustomer.MultiSelect = false;
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.RowHeadersWidth = 51;
            this.grdCustomer.RowTemplate.Height = 24;
            this.grdCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomer.Size = new System.Drawing.Size(1299, 286);
            this.grdCustomer.TabIndex = 58;
            this.grdCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellContentClick);
            // 
            // clmnCustomerID
            // 
            this.clmnCustomerID.DataPropertyName = "CustomerID";
            this.clmnCustomerID.HeaderText = "شناسه مشتری";
            this.clmnCustomerID.MinimumWidth = 6;
            this.clmnCustomerID.Name = "clmnCustomerID";
            this.clmnCustomerID.ToolTipText = "شناسه مشتری";
            this.clmnCustomerID.Visible = false;
            this.clmnCustomerID.Width = 125;
            // 
            // clmnUserID
            // 
            this.clmnUserID.DataPropertyName = "UserID";
            this.clmnUserID.HeaderText = "شناسه ی کاربری";
            this.clmnUserID.MinimumWidth = 6;
            this.clmnUserID.Name = "clmnUserID";
            this.clmnUserID.ToolTipText = "شناسه ی کاربری";
            this.clmnUserID.Visible = false;
            this.clmnUserID.Width = 125;
            // 
            // clmnFirstName
            // 
            this.clmnFirstName.DataPropertyName = "FirstName";
            this.clmnFirstName.HeaderText = "نام";
            this.clmnFirstName.MinimumWidth = 6;
            this.clmnFirstName.Name = "clmnFirstName";
            this.clmnFirstName.ToolTipText = "نام";
            this.clmnFirstName.Width = 125;
            // 
            // clmnLastName
            // 
            this.clmnLastName.DataPropertyName = "LastName";
            this.clmnLastName.HeaderText = "نام خانوادگی";
            this.clmnLastName.MinimumWidth = 6;
            this.clmnLastName.Name = "clmnLastName";
            this.clmnLastName.ToolTipText = "نام خانوادگی";
            this.clmnLastName.Width = 125;
            // 
            // clmnUserName
            // 
            this.clmnUserName.DataPropertyName = "UserName";
            this.clmnUserName.HeaderText = "کلمه عبور";
            this.clmnUserName.MinimumWidth = 6;
            this.clmnUserName.Name = "clmnUserName";
            this.clmnUserName.ToolTipText = "کلمه عبور";
            this.clmnUserName.Width = 125;
            // 
            // clmnPassword
            // 
            this.clmnPassword.DataPropertyName = "Password";
            this.clmnPassword.HeaderText = "رمز ورود";
            this.clmnPassword.MinimumWidth = 6;
            this.clmnPassword.Name = "clmnPassword";
            this.clmnPassword.ToolTipText = "رمز ورود";
            this.clmnPassword.Width = 125;
            // 
            // clmnMobile
            // 
            this.clmnMobile.DataPropertyName = "Mobile";
            this.clmnMobile.HeaderText = "موبایل";
            this.clmnMobile.MinimumWidth = 6;
            this.clmnMobile.Name = "clmnMobile";
            this.clmnMobile.ToolTipText = "موبایل";
            this.clmnMobile.Width = 125;
            // 
            // clmnEmail
            // 
            this.clmnEmail.DataPropertyName = "Email";
            this.clmnEmail.HeaderText = "ایمیل";
            this.clmnEmail.MinimumWidth = 6;
            this.clmnEmail.Name = "clmnEmail";
            this.clmnEmail.ToolTipText = "ایمیل";
            this.clmnEmail.Width = 125;
            // 
            // clmnAddress
            // 
            this.clmnAddress.DataPropertyName = "Address";
            this.clmnAddress.HeaderText = "آدرس";
            this.clmnAddress.MinimumWidth = 6;
            this.clmnAddress.Name = "clmnAddress";
            this.clmnAddress.ToolTipText = "آدرس";
            this.clmnAddress.Width = 125;
            // 
            // clmnIsActive
            // 
            this.clmnIsActive.DataPropertyName = "IsActive";
            this.clmnIsActive.HeaderText = "وضعیت فعالیت";
            this.clmnIsActive.MinimumWidth = 6;
            this.clmnIsActive.Name = "clmnIsActive";
            this.clmnIsActive.ReadOnly = true;
            this.clmnIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnIsActive.Width = 125;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 6;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 125;
            // 
            // clmnUpdate
            // 
            this.clmnUpdate.HeaderText = "ویرایش";
            this.clmnUpdate.MinimumWidth = 6;
            this.clmnUpdate.Name = "clmnUpdate";
            this.clmnUpdate.Text = "ویرایش";
            this.clmnUpdate.UseColumnTextForButtonValue = true;
            this.clmnUpdate.Width = 125;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1299, 703);
            this.Controls.Add(this.grdCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت مشتریان";
            this.Load += new System.EventHandler(this.frmCustomer_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDisactive;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
    }
}