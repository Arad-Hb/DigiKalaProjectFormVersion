using System;
using System.Windows.Forms;

namespace DigiKalaProject
{
    partial class frmProduct
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.clmnProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIsSaleable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDisactive = new System.Windows.Forms.RadioButton();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(143, 52);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(250, 30);
            this.txtProductName.TabIndex = 1;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(143, 125);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(250, 30);
            this.txtBasePrice.TabIndex = 2;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(143, 268);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(250, 30);
            this.txtRate.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(552, 202);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(423, 96);
            this.txtDescription.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "نام محصول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(30, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "قیمت پایه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(30, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "دسته بندی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(30, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "امتیاز";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(460, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "توضیحات";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(1112, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 41);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "ثبت";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdProduct
            // 
            this.grdProduct.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnProductID,
            this.clmnProductName,
            this.clmnCategoryName,
            this.clmnBasePrice,
            this.clmnRate,
            this.clmnIsSaleable,
            this.clmnDescription,
            this.clmnDelete,
            this.clmnEdit});
            this.grdProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdProduct.GridColor = System.Drawing.Color.LightSeaGreen;
            this.grdProduct.Location = new System.Drawing.Point(0, 560);
            this.grdProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdProduct.MultiSelect = false;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdProduct.RowHeadersWidth = 51;
            this.grdProduct.RowTemplate.Height = 24;
            this.grdProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProduct.Size = new System.Drawing.Size(1356, 491);
            this.grdProduct.TabIndex = 20;
            this.grdProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellContentClick_1);
            // 
            // clmnProductID
            // 
            this.clmnProductID.DataPropertyName = "ProductID";
            this.clmnProductID.HeaderText = "شناسه";
            this.clmnProductID.MinimumWidth = 6;
            this.clmnProductID.Name = "clmnProductID";
            this.clmnProductID.ToolTipText = "شناسه";
            this.clmnProductID.Visible = false;
            this.clmnProductID.Width = 125;
            // 
            // clmnProductName
            // 
            this.clmnProductName.DataPropertyName = "ProductName";
            this.clmnProductName.HeaderText = "نام محصول";
            this.clmnProductName.MinimumWidth = 6;
            this.clmnProductName.Name = "clmnProductName";
            this.clmnProductName.ToolTipText = "نام محصول";
            this.clmnProductName.Width = 125;
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
            // clmnBasePrice
            // 
            this.clmnBasePrice.DataPropertyName = "BasePrice";
            this.clmnBasePrice.HeaderText = "قیمت پایه";
            this.clmnBasePrice.MinimumWidth = 6;
            this.clmnBasePrice.Name = "clmnBasePrice";
            this.clmnBasePrice.ToolTipText = "قیمت پایه";
            this.clmnBasePrice.Width = 125;
            // 
            // clmnRate
            // 
            this.clmnRate.DataPropertyName = "Rate";
            this.clmnRate.HeaderText = "امتیاز";
            this.clmnRate.MinimumWidth = 6;
            this.clmnRate.Name = "clmnRate";
            this.clmnRate.ToolTipText = "امتیاز";
            this.clmnRate.Width = 125;
            // 
            // clmnIsSaleable
            // 
            this.clmnIsSaleable.DataPropertyName = "IsSaleable";
            this.clmnIsSaleable.HeaderText = "قابلیت فروش";
            this.clmnIsSaleable.MinimumWidth = 6;
            this.clmnIsSaleable.Name = "clmnIsSaleable";
            this.clmnIsSaleable.ToolTipText = "قابلیت فروش";
            this.clmnIsSaleable.Width = 125;
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
            this.clmnDelete.ReadOnly = true;
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 125;
            // 
            // clmnEdit
            // 
            this.clmnEdit.HeaderText = "ویرایش";
            this.clmnEdit.MinimumWidth = 6;
            this.clmnEdit.Name = "clmnEdit";
            this.clmnEdit.ReadOnly = true;
            this.clmnEdit.Text = "ویرایش";
            this.clmnEdit.UseColumnTextForButtonValue = true;
            this.clmnEdit.Width = 125;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(1112, 160);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 42);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(1112, 88);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 42);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(143, 202);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(250, 33);
            this.cmbCategory.TabIndex = 26;

            // 
            // err
            // 
            this.err.ContainerControl = this;
            this.err.RightToLeft = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.rdbDisactive);
            this.groupBox1.Controls.Add(this.rdbActive);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(465, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 101);
            this.groupBox1.TabIndex = 33;
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
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1356, 1051);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtProductName);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت محصول";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grdProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private ComboBox cmbCategory;
        private DataGridViewTextBoxColumn clmnProductID;
        private DataGridViewTextBoxColumn clmnProductName;
        private DataGridViewTextBoxColumn clmnCategoryName;
        private DataGridViewTextBoxColumn clmnBasePrice;
        private DataGridViewTextBoxColumn clmnRate;
        private DataGridViewTextBoxColumn clmnIsSaleable;
        private DataGridViewTextBoxColumn clmnDescription;
        private DataGridViewButtonColumn clmnDelete;
        private DataGridViewButtonColumn clmnEdit;
        private ErrorProvider err;
        private GroupBox groupBox1;
        private RadioButton rdbDisactive;
        private RadioButton rdbActive;
    }
}