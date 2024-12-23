namespace DigiKalaProject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اطلاعاتپایهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکارمندانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتمشتریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتفروشندگانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتمنوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دستهبندیهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.محصولاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فروشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتفاکتورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشفروشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتپایهToolStripMenuItem,
            this.مدیریتمنوToolStripMenuItem,
            this.فروشToolStripMenuItem,
            this.گزارشاتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1464, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // اطلاعاتپایهToolStripMenuItem
            // 
            this.اطلاعاتپایهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتکارمندانToolStripMenuItem,
            this.مدیریتمشتریToolStripMenuItem,
            this.مدیریتفروشندگانToolStripMenuItem});
            this.اطلاعاتپایهToolStripMenuItem.Name = "اطلاعاتپایهToolStripMenuItem";
            this.اطلاعاتپایهToolStripMenuItem.Size = new System.Drawing.Size(130, 32);
            this.اطلاعاتپایهToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // مدیریتکارمندانToolStripMenuItem
            // 
            this.مدیریتکارمندانToolStripMenuItem.Name = "مدیریتکارمندانToolStripMenuItem";
            this.مدیریتکارمندانToolStripMenuItem.Size = new System.Drawing.Size(256, 32);
            this.مدیریتکارمندانToolStripMenuItem.Text = "مدیریت کارمندان";
            this.مدیریتکارمندانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتکارمندانToolStripMenuItem_Click);
            // 
            // مدیریتمشتریToolStripMenuItem
            // 
            this.مدیریتمشتریToolStripMenuItem.Name = "مدیریتمشتریToolStripMenuItem";
            this.مدیریتمشتریToolStripMenuItem.Size = new System.Drawing.Size(256, 32);
            this.مدیریتمشتریToolStripMenuItem.Text = "مدیریت مشتریان";
            this.مدیریتمشتریToolStripMenuItem.Click += new System.EventHandler(this.مدیریتمشتریToolStripMenuItem_Click);
            // 
            // مدیریتفروشندگانToolStripMenuItem
            // 
            this.مدیریتفروشندگانToolStripMenuItem.Name = "مدیریتفروشندگانToolStripMenuItem";
            this.مدیریتفروشندگانToolStripMenuItem.Size = new System.Drawing.Size(256, 32);
            this.مدیریتفروشندگانToolStripMenuItem.Text = "مدیریت فروشندگان";
            // 
            // مدیریتمنوToolStripMenuItem
            // 
            this.مدیریتمنوToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دستهبندیهاToolStripMenuItem,
            this.محصولاتToolStripMenuItem});
            this.مدیریتمنوToolStripMenuItem.Name = "مدیریتمنوToolStripMenuItem";
            this.مدیریتمنوToolStripMenuItem.Size = new System.Drawing.Size(125, 32);
            this.مدیریتمنوToolStripMenuItem.Text = "مدیریت منو";
            // 
            // دستهبندیهاToolStripMenuItem
            // 
            this.دستهبندیهاToolStripMenuItem.Name = "دستهبندیهاToolStripMenuItem";
            this.دستهبندیهاToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.دستهبندیهاToolStripMenuItem.Text = "دسته بندی ها";
            this.دستهبندیهاToolStripMenuItem.Click += new System.EventHandler(this.دستهبندیهاToolStripMenuItem_Click);
            // 
            // محصولاتToolStripMenuItem
            // 
            this.محصولاتToolStripMenuItem.Name = "محصولاتToolStripMenuItem";
            this.محصولاتToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.محصولاتToolStripMenuItem.Text = "محصولات";
            this.محصولاتToolStripMenuItem.Click += new System.EventHandler(this.محصولاتToolStripMenuItem_Click);
            // 
            // فروشToolStripMenuItem
            // 
            this.فروشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتفاکتورToolStripMenuItem});
            this.فروشToolStripMenuItem.Name = "فروشToolStripMenuItem";
            this.فروشToolStripMenuItem.Size = new System.Drawing.Size(75, 32);
            this.فروشToolStripMenuItem.Text = "فروش";
            // 
            // ثبتفاکتورToolStripMenuItem
            // 
            this.ثبتفاکتورToolStripMenuItem.Name = "ثبتفاکتورToolStripMenuItem";
            this.ثبتفاکتورToolStripMenuItem.Size = new System.Drawing.Size(186, 32);
            this.ثبتفاکتورToolStripMenuItem.Text = "ثبت فاکتور";
            this.ثبتفاکتورToolStripMenuItem.Click += new System.EventHandler(this.ثبتفاکتورToolStripMenuItem_Click);
            // 
            // گزارشاتToolStripMenuItem
            // 
            this.گزارشاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشفروشToolStripMenuItem});
            this.گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem";
            this.گزارشاتToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.گزارشاتToolStripMenuItem.Text = "گزارشات";
            // 
            // گزارشفروشToolStripMenuItem
            // 
            this.گزارشفروشToolStripMenuItem.Name = "گزارشفروشToolStripMenuItem";
            this.گزارشفروشToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.گزارشفروشToolStripMenuItem.Text = "گزارش فروش";
            this.گزارشفروشToolStripMenuItem.Click += new System.EventHandler(this.گزارشفروشToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 749);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1464, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "تاریخ و زمان امروز";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(111, 28);
            this.lblDateTime.Text = "toolStripLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1464, 780);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فرم مدیریت";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکارمندانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتمشتریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتفروشندگانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتمنوToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دستهبندیهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem محصولاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فروشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتفاکتورToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem گزارشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشفروشToolStripMenuItem;
    }
}