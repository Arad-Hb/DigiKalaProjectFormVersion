namespace DigiKalaProject
{
    partial class frmOrderItemsReport
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
            this.grdOrderItemsReport = new System.Windows.Forms.DataGridView();
            this.clmnOrderItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderItemsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrderItemsReport
            // 
            this.grdOrderItemsReport.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.grdOrderItemsReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdOrderItemsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderItemsReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnOrderItemID,
            this.clmnOrderID,
            this.clmnProductID,
            this.clmnProductName,
            this.clmnBasePrice,
            this.clmnQuantity,
            this.clmnTotalPrice,
            this.btnEdit,
            this.btnDelete});
            this.grdOrderItemsReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdOrderItemsReport.Location = new System.Drawing.Point(0, -1);
            this.grdOrderItemsReport.MultiSelect = false;
            this.grdOrderItemsReport.Name = "grdOrderItemsReport";
            this.grdOrderItemsReport.RowHeadersWidth = 51;
            this.grdOrderItemsReport.RowTemplate.Height = 24;
            this.grdOrderItemsReport.Size = new System.Drawing.Size(1377, 603);
            this.grdOrderItemsReport.TabIndex = 14;
            this.grdOrderItemsReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderItemsReport_CellContentClick);
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
            // frmOrderItemsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 602);
            this.Controls.Add(this.grdOrderItemsReport);
            this.Enabled = false;
            this.Name = "frmOrderItemsReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فرم گزارش جزییات فاکتور";
            this.Load += new System.EventHandler(this.frmOrderItemsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderItemsReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrderItemsReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOrderItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}