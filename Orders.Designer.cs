namespace CafeeShopSample
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtOrdersCount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalPrices = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductId,
            this.ProductCaption,
            this.Count,
            this.Price,
            this.PriceStr});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(670, 388);
            this.dgvOrder.TabIndex = 20;
            this.dgvOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrder_CellFormatting);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::CafeeShopSample.Properties.Resources.icons8_delete_64;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteToolStripMenuItem.Text = "حذف سفارش";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(122, 25);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(285, 32);
            this.cbCustomer.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "مشتری";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 388);
            this.panel1.TabIndex = 30;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtOrdersCount);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(845, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 88);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تعداد سفارشات";
            // 
            // txtOrdersCount
            // 
            this.txtOrdersCount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtOrdersCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtOrdersCount.Location = new System.Drawing.Point(6, 28);
            this.txtOrdersCount.Multiline = true;
            this.txtOrdersCount.Name = "txtOrdersCount";
            this.txtOrdersCount.Size = new System.Drawing.Size(106, 46);
            this.txtOrdersCount.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalPrices);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(626, 484);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 88);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مبلغ کل";
            // 
            // txtTotalPrices
            // 
            this.txtTotalPrices.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTotalPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTotalPrices.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPrices.Location = new System.Drawing.Point(6, 28);
            this.txtTotalPrices.Multiline = true;
            this.txtTotalPrices.Name = "txtTotalPrices";
            this.txtTotalPrices.Size = new System.Drawing.Size(197, 46);
            this.txtTotalPrices.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOrder);
            this.panel2.Location = new System.Drawing.Point(461, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 388);
            this.panel2.TabIndex = 31;
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertOrder.Location = new System.Drawing.Point(12, 484);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInsertOrder.Size = new System.Drawing.Size(140, 88);
            this.btnInsertOrder.TabIndex = 33;
            this.btnInsertOrder.Text = "ثبت و بستن";
            this.btnInsertOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInsertOrder.UseVisualStyleBackColor = true;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(158, 483);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new System.Drawing.Size(151, 88);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "ثبت و چاپ فاکتور";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Id
            // 
            this.Id.ContextMenuStrip = this.contextMenuStrip1;
            this.Id.HeaderText = "ردیف";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // ProductId
            // 
            this.ProductId.ContextMenuStrip = this.contextMenuStrip1;
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            this.ProductId.Width = 115;
            // 
            // ProductCaption
            // 
            this.ProductCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCaption.ContextMenuStrip = this.contextMenuStrip1;
            this.ProductCaption.DataPropertyName = "ProductCaption";
            this.ProductCaption.HeaderText = "سفارشات";
            this.ProductCaption.Name = "ProductCaption";
            this.ProductCaption.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.ContextMenuStrip = this.contextMenuStrip1;
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "تعداد";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 63;
            // 
            // Price
            // 
            this.Price.ContextMenuStrip = this.contextMenuStrip1;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
            this.Price.Width = 78;
            // 
            // PriceStr
            // 
            this.PriceStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceStr.ContextMenuStrip = this.contextMenuStrip1;
            this.PriceStr.DataPropertyName = "PriceStr";
            this.PriceStr.HeaderText = "قیمت";
            this.PriceStr.Name = "PriceStr";
            this.PriceStr.ReadOnly = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(315, 484);
            this.btnNew.Name = "btnNew";
            this.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNew.Size = new System.Drawing.Size(140, 88);
            this.btnNew.TabIndex = 33;
            this.btnNew.Text = "ثبت و جدید";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 584);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnInsertOrder);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Orders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت سفارش";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtOrdersCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalPrices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInsertOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceStr;
        private System.Windows.Forms.Button btnNew;
    }
}