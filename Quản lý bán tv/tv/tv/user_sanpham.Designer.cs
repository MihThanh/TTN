namespace tv
{
    partial class user_sanpham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_sanpham));
            this.panel5 = new System.Windows.Forms.Panel();
            this.but_tim_sp = new System.Windows.Forms.Button();
            this.txt_tim_sp = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.date_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_mansx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tennsx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.but_xoa_sp = new System.Windows.Forms.Button();
            this.but_sua_sp = new System.Windows.Forms.Button();
            this.but_them_sp = new System.Windows.Forms.Button();
            this.data_sp = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.but_tim_sp);
            this.panel5.Controls.Add(this.txt_tim_sp);
            this.panel5.Location = new System.Drawing.Point(5, 357);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 50);
            this.panel5.TabIndex = 1;
            // 
            // but_tim_sp
            // 
            this.but_tim_sp.Image = ((System.Drawing.Image)(resources.GetObject("but_tim_sp.Image")));
            this.but_tim_sp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_tim_sp.Location = new System.Drawing.Point(6, 1);
            this.but_tim_sp.Name = "but_tim_sp";
            this.but_tim_sp.Size = new System.Drawing.Size(85, 44);
            this.but_tim_sp.TabIndex = 1;
            this.but_tim_sp.Text = "Tìm";
            this.but_tim_sp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_tim_sp.UseVisualStyleBackColor = true;
            this.but_tim_sp.Click += new System.EventHandler(this.but_tim_sp_Click);
            // 
            // txt_tim_sp
            // 
            this.txt_tim_sp.Location = new System.Drawing.Point(107, 12);
            this.txt_tim_sp.Name = "txt_tim_sp";
            this.txt_tim_sp.Size = new System.Drawing.Size(174, 20);
            this.txt_tim_sp.TabIndex = 0;
            this.txt_tim_sp.TextChanged += new System.EventHandler(this.txt_tim_sp_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.date_ngaynhap);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.txt_mansx);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.txt_gia);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txt_tennsx);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.txt_tensp);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.txt_masp);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(5, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(293, 338);
            this.panel7.TabIndex = 2;
            // 
            // date_ngaynhap
            // 
            this.date_ngaynhap.CustomFormat = "MM/dd/yyyy";
            this.date_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngaynhap.Location = new System.Drawing.Point(106, 273);
            this.date_ngaynhap.Name = "date_ngaynhap";
            this.date_ngaynhap.Size = new System.Drawing.Size(171, 20);
            this.date_ngaynhap.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày nhập:";
            // 
            // txt_mansx
            // 
            this.txt_mansx.Location = new System.Drawing.Point(110, 137);
            this.txt_mansx.Name = "txt_mansx";
            this.txt_mansx.Size = new System.Drawing.Size(171, 20);
            this.txt_mansx.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã NSX:";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(107, 225);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(171, 20);
            this.txt_gia.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá:";
            // 
            // txt_tennsx
            // 
            this.txt_tennsx.Location = new System.Drawing.Point(109, 182);
            this.txt_tennsx.Name = "txt_tennsx";
            this.txt_tennsx.Size = new System.Drawing.Size(171, 20);
            this.txt_tennsx.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên NSX:";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(110, 86);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(171, 20);
            this.txt_tensp.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(110, 37);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(171, 20);
            this.txt_masp.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sản phẩm:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.but_xoa_sp);
            this.panel6.Controls.Add(this.but_sua_sp);
            this.panel6.Controls.Add(this.but_them_sp);
            this.panel6.Controls.Add(this.data_sp);
            this.panel6.Location = new System.Drawing.Point(305, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(512, 395);
            this.panel6.TabIndex = 3;
            // 
            // but_xoa_sp
            // 
            this.but_xoa_sp.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa_sp.Image")));
            this.but_xoa_sp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_xoa_sp.Location = new System.Drawing.Point(334, 340);
            this.but_xoa_sp.Name = "but_xoa_sp";
            this.but_xoa_sp.Size = new System.Drawing.Size(85, 44);
            this.but_xoa_sp.TabIndex = 1;
            this.but_xoa_sp.Text = "Xóa";
            this.but_xoa_sp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_xoa_sp.UseVisualStyleBackColor = true;
            this.but_xoa_sp.Click += new System.EventHandler(this.but_xoa_sp_Click);
            // 
            // but_sua_sp
            // 
            this.but_sua_sp.Image = ((System.Drawing.Image)(resources.GetObject("but_sua_sp.Image")));
            this.but_sua_sp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_sua_sp.Location = new System.Drawing.Point(199, 340);
            this.but_sua_sp.Name = "but_sua_sp";
            this.but_sua_sp.Size = new System.Drawing.Size(85, 44);
            this.but_sua_sp.TabIndex = 2;
            this.but_sua_sp.Text = "Sửa";
            this.but_sua_sp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_sua_sp.UseVisualStyleBackColor = true;
            this.but_sua_sp.Click += new System.EventHandler(this.but_sua_sp_Click);
            // 
            // but_them_sp
            // 
            this.but_them_sp.Image = ((System.Drawing.Image)(resources.GetObject("but_them_sp.Image")));
            this.but_them_sp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_them_sp.Location = new System.Drawing.Point(65, 340);
            this.but_them_sp.Name = "but_them_sp";
            this.but_them_sp.Size = new System.Drawing.Size(85, 44);
            this.but_them_sp.TabIndex = 3;
            this.but_them_sp.Text = "Thêm";
            this.but_them_sp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_them_sp.UseVisualStyleBackColor = true;
            this.but_them_sp.Click += new System.EventHandler(this.but_them_sp_Click);
            // 
            // data_sp
            // 
            this.data_sp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_sp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.MANSX,
            this.TENNSX,
            this.GIA,
            this.NGAYNHAP});
            this.data_sp.Location = new System.Drawing.Point(3, 2);
            this.data_sp.Name = "data_sp";
            this.data_sp.Size = new System.Drawing.Size(504, 332);
            this.data_sp.TabIndex = 0;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            // 
            // MANSX
            // 
            this.MANSX.DataPropertyName = "MANSX";
            this.MANSX.HeaderText = "Mã NSX";
            this.MANSX.Name = "MANSX";
            // 
            // TENNSX
            // 
            this.TENNSX.DataPropertyName = "TENNSX";
            this.TENNSX.HeaderText = "Tên NSX";
            this.TENNSX.Name = "TENNSX";
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Giá";
            this.GIA.Name = "GIA";
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            // 
            // user_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Name = "user_sanpham";
            this.Size = new System.Drawing.Size(854, 420);
            this.Load += new System.EventHandler(this.user_sanpham_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_sp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button but_tim_sp;
        private System.Windows.Forms.TextBox txt_tim_sp;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker date_ngaynhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mansx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tennsx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button but_xoa_sp;
        private System.Windows.Forms.Button but_sua_sp;
        private System.Windows.Forms.Button but_them_sp;
        private System.Windows.Forms.DataGridView data_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
    }
}
