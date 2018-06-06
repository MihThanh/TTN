namespace tv
{
    partial class f_hethong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_hethong));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.but_thanhtoan = new System.Windows.Forms.Button();
            this.but_thongke = new System.Windows.Forms.Button();
            this.but_sanpham = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_nhanvien = new System.Windows.Forms.Button();
            this.but_kh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.tool_thongtin,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.adminToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tool_thongtin
            // 
            this.tool_thongtin.Name = "tool_thongtin";
            this.tool_thongtin.Size = new System.Drawing.Size(123, 20);
            this.tool_thongtin.Text = "Thông tin tài khoản";
            this.tool_thongtin.Click += new System.EventHandler(this.tool_thongtin_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 113);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(786, 468);
            this.panel.TabIndex = 3;
            // 
            // but_thanhtoan
            // 
            this.but_thanhtoan.Image = ((System.Drawing.Image)(resources.GetObject("but_thanhtoan.Image")));
            this.but_thanhtoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_thanhtoan.Location = new System.Drawing.Point(33, 37);
            this.but_thanhtoan.Name = "but_thanhtoan";
            this.but_thanhtoan.Size = new System.Drawing.Size(105, 58);
            this.but_thanhtoan.TabIndex = 0;
            this.but_thanhtoan.Text = "Thanh toán";
            this.but_thanhtoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_thanhtoan.UseVisualStyleBackColor = true;
            this.but_thanhtoan.Click += new System.EventHandler(this.but_thanhtoan_Click);
            // 
            // but_thongke
            // 
            this.but_thongke.Image = ((System.Drawing.Image)(resources.GetObject("but_thongke.Image")));
            this.but_thongke.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_thongke.Location = new System.Drawing.Point(159, 37);
            this.but_thongke.Name = "but_thongke";
            this.but_thongke.Size = new System.Drawing.Size(105, 58);
            this.but_thongke.TabIndex = 1;
            this.but_thongke.Text = "Thống kê";
            this.but_thongke.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_thongke.UseVisualStyleBackColor = true;
            this.but_thongke.Click += new System.EventHandler(this.but_thongke_Click);
            // 
            // but_sanpham
            // 
            this.but_sanpham.Image = ((System.Drawing.Image)(resources.GetObject("but_sanpham.Image")));
            this.but_sanpham.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_sanpham.Location = new System.Drawing.Point(289, 37);
            this.but_sanpham.Name = "but_sanpham";
            this.but_sanpham.Size = new System.Drawing.Size(105, 58);
            this.but_sanpham.TabIndex = 2;
            this.but_sanpham.Text = "Sản phẩm";
            this.but_sanpham.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_sanpham.Click += new System.EventHandler(this.but_sanpham_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(424, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nhà cung cấp";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_nhanvien
            // 
            this.but_nhanvien.Image = ((System.Drawing.Image)(resources.GetObject("but_nhanvien.Image")));
            this.but_nhanvien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_nhanvien.Location = new System.Drawing.Point(553, 37);
            this.but_nhanvien.Name = "but_nhanvien";
            this.but_nhanvien.Size = new System.Drawing.Size(105, 58);
            this.but_nhanvien.TabIndex = 4;
            this.but_nhanvien.Text = "Nhân viên";
            this.but_nhanvien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_nhanvien.UseVisualStyleBackColor = true;
            this.but_nhanvien.Click += new System.EventHandler(this.but_nhanvien_Click);
            // 
            // but_kh
            // 
            this.but_kh.Image = ((System.Drawing.Image)(resources.GetObject("but_kh.Image")));
            this.but_kh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_kh.Location = new System.Drawing.Point(679, 37);
            this.but_kh.Name = "but_kh";
            this.but_kh.Size = new System.Drawing.Size(105, 58);
            this.but_kh.TabIndex = 5;
            this.but_kh.Text = "Khách hàng";
            this.but_kh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_kh.UseVisualStyleBackColor = true;
            this.but_kh.Click += new System.EventHandler(this.but_kh_Click);
            // 
            // f_hethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 593);
            this.Controls.Add(this.but_kh);
            this.Controls.Add(this.but_nhanvien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.but_sanpham);
            this.Controls.Add(this.but_thongke);
            this.Controls.Add(this.but_thanhtoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_hethong";
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool_thongtin;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button but_thanhtoan;
        private System.Windows.Forms.Button but_thongke;
        private System.Windows.Forms.Button but_sanpham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_nhanvien;
        private System.Windows.Forms.Button but_kh;
    }
}

