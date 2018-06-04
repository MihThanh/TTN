namespace WindowsFormsApplication2
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
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_kh = new System.Windows.Forms.Button();
            this.but_nv = new System.Windows.Forms.Button();
            this.but_hdn = new System.Windows.Forms.Button();
            this.but_hdb = new System.Windows.Forms.Button();
            this.but_sp = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.but_ncc = new System.Windows.Forms.Button();
            this.but_loai = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click_1);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // but_kh
            // 
            this.but_kh.Image = ((System.Drawing.Image)(resources.GetObject("but_kh.Image")));
            this.but_kh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_kh.Location = new System.Drawing.Point(12, 37);
            this.but_kh.Name = "but_kh";
            this.but_kh.Size = new System.Drawing.Size(105, 67);
            this.but_kh.TabIndex = 4;
            this.but_kh.Text = "Khách hàng";
            this.but_kh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_kh.UseVisualStyleBackColor = true;
            this.but_kh.Click += new System.EventHandler(this.but_kh_Click);
            // 
            // but_nv
            // 
            this.but_nv.Image = ((System.Drawing.Image)(resources.GetObject("but_nv.Image")));
            this.but_nv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_nv.Location = new System.Drawing.Point(123, 37);
            this.but_nv.Name = "but_nv";
            this.but_nv.Size = new System.Drawing.Size(105, 67);
            this.but_nv.TabIndex = 4;
            this.but_nv.Text = "Nhân viên";
            this.but_nv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_nv.UseVisualStyleBackColor = true;
            this.but_nv.Click += new System.EventHandler(this.but_nv_Click);
            // 
            // but_hdn
            // 
            this.but_hdn.Image = ((System.Drawing.Image)(resources.GetObject("but_hdn.Image")));
            this.but_hdn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_hdn.Location = new System.Drawing.Point(234, 37);
            this.but_hdn.Name = "but_hdn";
            this.but_hdn.Size = new System.Drawing.Size(105, 67);
            this.but_hdn.TabIndex = 4;
            this.but_hdn.Text = "Hóa đơn nhập";
            this.but_hdn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_hdn.UseVisualStyleBackColor = true;
            this.but_hdn.Click += new System.EventHandler(this.but_hdn_Click);
            // 
            // but_hdb
            // 
            this.but_hdb.Image = ((System.Drawing.Image)(resources.GetObject("but_hdb.Image")));
            this.but_hdb.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_hdb.Location = new System.Drawing.Point(345, 37);
            this.but_hdb.Name = "but_hdb";
            this.but_hdb.Size = new System.Drawing.Size(105, 67);
            this.but_hdb.TabIndex = 4;
            this.but_hdb.Text = "Hóa đơn bán";
            this.but_hdb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_hdb.UseVisualStyleBackColor = true;
            this.but_hdb.Click += new System.EventHandler(this.but_hdb_Click);
            // 
            // but_sp
            // 
            this.but_sp.Image = ((System.Drawing.Image)(resources.GetObject("but_sp.Image")));
            this.but_sp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_sp.Location = new System.Drawing.Point(456, 37);
            this.but_sp.Name = "but_sp";
            this.but_sp.Size = new System.Drawing.Size(105, 67);
            this.but_sp.TabIndex = 4;
            this.but_sp.Text = "Sản phẩm";
            this.but_sp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_sp.UseVisualStyleBackColor = true;
            this.but_sp.Click += new System.EventHandler(this.but_sp_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 110);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(834, 353);
            this.panel.TabIndex = 5;
            // 
            // but_ncc
            // 
            this.but_ncc.Image = ((System.Drawing.Image)(resources.GetObject("but_ncc.Image")));
            this.but_ncc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_ncc.Location = new System.Drawing.Point(567, 37);
            this.but_ncc.Name = "but_ncc";
            this.but_ncc.Size = new System.Drawing.Size(107, 67);
            this.but_ncc.TabIndex = 6;
            this.but_ncc.Text = "Nhà cung cấp";
            this.but_ncc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_ncc.UseVisualStyleBackColor = true;
            this.but_ncc.Click += new System.EventHandler(this.but_ncc_Click);
            // 
            // but_loai
            // 
            this.but_loai.Image = ((System.Drawing.Image)(resources.GetObject("but_loai.Image")));
            this.but_loai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_loai.Location = new System.Drawing.Point(680, 37);
            this.but_loai.Name = "but_loai";
            this.but_loai.Size = new System.Drawing.Size(101, 67);
            this.but_loai.TabIndex = 7;
            this.but_loai.Text = "Loại hàng";
            this.but_loai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_loai.UseVisualStyleBackColor = true;
            this.but_loai.Click += new System.EventHandler(this.but_loai_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 473);
            this.Controls.Add(this.but_loai);
            this.Controls.Add(this.but_ncc);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.but_sp);
            this.Controls.Add(this.but_hdb);
            this.Controls.Add(this.but_hdn);
            this.Controls.Add(this.but_nv);
            this.Controls.Add(this.but_kh);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button but_kh;
        private System.Windows.Forms.Button but_nv;
        private System.Windows.Forms.Button but_hdn;
        private System.Windows.Forms.Button but_hdb;
        private System.Windows.Forms.Button but_sp;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button but_ncc;
        private System.Windows.Forms.Button but_loai;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
    }
}