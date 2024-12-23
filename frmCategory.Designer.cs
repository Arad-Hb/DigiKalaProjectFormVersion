namespace DigiKalaProject
{
    partial class frmCategory
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
            this.grdCategory = new System.Windows.Forms.DataGridView();
            this.clmnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnParentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnChildCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLineage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtParentID = new System.Windows.Forms.TextBox();
            this.txtChildCount = new System.Windows.Forms.TextBox();
            this.txtLineage = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCategory
            // 
            this.grdCategory.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.grdCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCategoryID,
            this.clmnCategoryName,
            this.clmnParentID,
            this.clmnChildCount,
            this.clmnLineage,
            this.clmnDescription,
            this.clmnDelete,
            this.clmnUpdate});
            this.grdCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdCategory.Location = new System.Drawing.Point(0, 380);
            this.grdCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdCategory.MultiSelect = false;
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdCategory.RowHeadersWidth = 51;
            this.grdCategory.RowTemplate.Height = 24;
            this.grdCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCategory.Size = new System.Drawing.Size(1051, 323);
            this.grdCategory.TabIndex = 0;
            this.grdCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategory_CellContentClick);
            // 
            // clmnCategoryID
            // 
            this.clmnCategoryID.DataPropertyName = "CategoryID";
            this.clmnCategoryID.HeaderText = "شناسه";
            this.clmnCategoryID.MinimumWidth = 6;
            this.clmnCategoryID.Name = "clmnCategoryID";
            this.clmnCategoryID.ToolTipText = "شناسه";
            this.clmnCategoryID.Visible = false;
            this.clmnCategoryID.Width = 125;
            // 
            // clmnCategoryName
            // 
            this.clmnCategoryName.DataPropertyName = "CategoryName";
            this.clmnCategoryName.HeaderText = "نام رده";
            this.clmnCategoryName.MinimumWidth = 6;
            this.clmnCategoryName.Name = "clmnCategoryName";
            this.clmnCategoryName.ToolTipText = "نام رده";
            this.clmnCategoryName.Width = 125;
            // 
            // clmnParentID
            // 
            this.clmnParentID.DataPropertyName = "ParentID";
            this.clmnParentID.HeaderText = "شناسه والد";
            this.clmnParentID.MinimumWidth = 6;
            this.clmnParentID.Name = "clmnParentID";
            this.clmnParentID.ToolTipText = "شناسه والد";
            this.clmnParentID.Width = 125;
            // 
            // clmnChildCount
            // 
            this.clmnChildCount.DataPropertyName = "ChildCount";
            this.clmnChildCount.HeaderText = "تعداد زیررده مستقیم";
            this.clmnChildCount.MinimumWidth = 6;
            this.clmnChildCount.Name = "clmnChildCount";
            this.clmnChildCount.ToolTipText = "تعداد زیررده مستقیم";
            this.clmnChildCount.Width = 125;
            // 
            // clmnLineage
            // 
            this.clmnLineage.DataPropertyName = "Lineage";
            this.clmnLineage.HeaderText = "کد لاین ایج";
            this.clmnLineage.MinimumWidth = 6;
            this.clmnLineage.Name = "clmnLineage";
            this.clmnLineage.ToolTipText = "کد لاین ایج";
            this.clmnLineage.Width = 125;
            // 
            // clmnDescription
            // 
            this.clmnDescription.DataPropertyName = "Description";
            this.clmnDescription.HeaderText = "توضیحات";
            this.clmnDescription.MinimumWidth = 6;
            this.clmnDescription.Name = "clmnDescription";
            this.clmnDescription.ToolTipText = "توضیحات";
            this.clmnDescription.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام رده";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "شناسه ی والد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "تعداد زیر رده ی مستقیم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "کد لاین ایج";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "توضیحات";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(246, 40);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(210, 30);
            this.txtCategoryName.TabIndex = 11;
            // 
            // txtParentID
            // 
            this.txtParentID.Location = new System.Drawing.Point(246, 106);
            this.txtParentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.Size = new System.Drawing.Size(210, 30);
            this.txtParentID.TabIndex = 12;
            // 
            // txtChildCount
            // 
            this.txtChildCount.Location = new System.Drawing.Point(246, 181);
            this.txtChildCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChildCount.Name = "txtChildCount";
            this.txtChildCount.Size = new System.Drawing.Size(210, 30);
            this.txtChildCount.TabIndex = 13;
            // 
            // txtLineage
            // 
            this.txtLineage.Location = new System.Drawing.Point(246, 240);
            this.txtLineage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLineage.Name = "txtLineage";
            this.txtLineage.Size = new System.Drawing.Size(210, 30);
            this.txtLineage.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(494, 73);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(308, 197);
            this.txtDescription.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(832, 45);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 42);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ثبت";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1051, 30);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEdit.Location = new System.Drawing.Point(832, 128);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(194, 42);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(832, 211);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 42);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1051, 703);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLineage);
            this.Controls.Add(this.txtChildCount);
            this.Controls.Add(this.txtParentID);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCategory);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت دسته بندی";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtParentID;
        private System.Windows.Forms.TextBox txtChildCount;
        private System.Windows.Forms.TextBox txtLineage;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnParentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnChildCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLineage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescription;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
    }
}