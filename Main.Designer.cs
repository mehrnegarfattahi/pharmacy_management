namespace CafeeShopSample
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baseMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseMaterialToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baseMaterialToolStripMenuItem
            // 
            this.baseMaterialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.toolStripMenuItem2,
            this.usersToolStripMenuItem});
            this.baseMaterialToolStripMenuItem.Name = "baseMaterialToolStripMenuItem";
            this.baseMaterialToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.baseMaterialToolStripMenuItem.Text = "تعاریف پایه";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productsToolStripMenuItem.Text = "مدیریت منو";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Image = global::CafeeShopSample.Properties.Resources.icons8_customers_64;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.customersToolStripMenuItem.Text = "مدیریت مشتریان";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::CafeeShopSample.Properties.Resources.icons8_users_64;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usersToolStripMenuItem.Text = "مدیریت کاربران";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saleReportToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.actionsToolStripMenuItem.Image = global::CafeeShopSample.Properties.Resources.icons8_adjust_64;
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.actionsToolStripMenuItem.Text = "عملیات";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Image = global::CafeeShopSample.Properties.Resources.icons8_food_64;
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.orderToolStripMenuItem.Text = "ثبت سفارش";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // saleReportToolStripMenuItem
            // 
            this.saleReportToolStripMenuItem.Image = global::CafeeShopSample.Properties.Resources.icons8_graph_report_64;
            this.saleReportToolStripMenuItem.Name = "saleReportToolStripMenuItem";
            this.saleReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saleReportToolStripMenuItem.Text = "گزارش فروش";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::CafeeShopSample.Properties.Resources.icons8_exit_64;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 374);
            this.panel1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت داروخانه";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baseMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.Panel panel1;
    }
}