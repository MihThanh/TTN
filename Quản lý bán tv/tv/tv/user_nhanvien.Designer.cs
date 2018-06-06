namespace tv
{
    partial class user_nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_nhanvien));
            this.but_sua_nv = new System.Windows.Forms.Button();
            this.data_nv = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_them_nv = new System.Windows.Forms.Button();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.but_xoa_nv = new System.Windows.Forms.Button();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.but_tim_nv = new System.Windows.Forms.Button();
            this.txt_tim_nv = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_sua_nv
            // 
            this.but_sua_nv.Image = ((System.Drawing.Image)(resources.GetObject("but_sua_nv.Image")));
            this.but_sua_nv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_sua_nv.Location = new System.Drawing.Point(199, 340);
            this.but_sua_nv.Name = "but_sua_nv";
            this.but_sua_nv.Size = new System.Drawing.Size(85, 44);
            this.but_sua_nv.TabIndex = 2;
            this.but_sua_nv.Text = "Sửa";
            this.but_sua_nv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_sua_nv.UseVisualStyleBackColor = true;
            this.but_sua_nv.Click += new System.EventHandler(this.but_sua_sp_Click);
            // 
            // data_nv
            // 
            this.data_nv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.sdt,
            this.NGAYSINH});
            this.data_nv.Location = new System.Drawing.Point(3, 2);
            this.data_nv.Name = "data_nv";
            this.data_nv.Size = new System.Drawing.Size(504, 332);
            this.data_nv.TabIndex = 0;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Tên nhân viên";
            this.HOTEN.Name = "HOTEN";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // but_them_nv
            // 
            this.but_them_nv.Image = ((System.Drawing.Image)(resources.GetObject("but_them_nv.Image")));
            this.but_them_nv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_them_nv.Location = new System.Drawing.Point(65, 340);
            this.but_them_nv.Name = "but_them_nv";
            this.but_them_nv.Size = new System.Drawing.Size(85, 44);
            this.but_them_nv.TabIndex = 3;
            this.but_them_nv.Text = "Thêm";
            this.but_them_nv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_them_nv.UseVisualStyleBackColor = true;
            this.but_them_nv.Click += new System.EventHandler(this.but_them_sp_Click);
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.CustomFormat = "MM/dd/yyyy";
            this.date_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngaysinh.Location = new System.Drawing.Point(106, 244);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(165, 20);
            this.date_ngaysinh.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày sinh:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(106, 180);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(165, 20);
            this.txt_sdt.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số điện thoại:";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(106, 117);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(165, 20);
            this.txt_tennv.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên nhân viên:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.but_xoa_nv);
            this.panel6.Controls.Add(this.but_sua_nv);
            this.panel6.Controls.Add(this.but_them_nv);
            this.panel6.Controls.Add(this.data_nv);
            this.panel6.Location = new System.Drawing.Point(309, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(512, 395);
            this.panel6.TabIndex = 6;
            // 
            // but_xoa_nv
            // 
            this.but_xoa_nv.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa_nv.Image")));
            this.but_xoa_nv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_xoa_nv.Location = new System.Drawing.Point(334, 340);
            this.but_xoa_nv.Name = "but_xoa_nv";
            this.but_xoa_nv.Size = new System.Drawing.Size(85, 44);
            this.but_xoa_nv.TabIndex = 1;
            this.but_xoa_nv.Text = "Xóa";
            this.but_xoa_nv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_xoa_nv.UseVisualStyleBackColor = true;
            this.but_xoa_nv.Click += new System.EventHandler(this.but_xoa_sp_Click);
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(107, 54);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(165, 20);
            this.txt_manv.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhân viên:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.date_ngaysinh);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.txt_sdt);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txt_tennv);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.txt_manv);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(9, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(293, 338);
            this.panel7.TabIndex = 5;
            // 
            // but_tim_nv
            // 
            this.but_tim_nv.Image = ((System.Drawing.Image)(resources.GetObject("but_tim_nv.Image")));
            this.but_tim_nv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_tim_nv.Location = new System.Drawing.Point(6, 1);
            this.but_tim_nv.Name = "but_tim_nv";
            this.but_tim_nv.Size = new System.Drawing.Size(85, 44);
            this.but_tim_nv.TabIndex = 1;
            this.but_tim_nv.Text = "Tìm";
            this.but_tim_nv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_tim_nv.UseVisualStyleBackColor = true;
            // 
            // txt_tim_nv
            // 
            this.txt_tim_nv.Location = new System.Drawing.Point(107, 12);
            this.txt_tim_nv.Name = "txt_tim_nv";
            this.txt_tim_nv.Size = new System.Drawing.Size(174, 20);
            this.txt_tim_nv.TabIndex = 0;
            this.txt_tim_nv.TextChanged += new System.EventHandler(this.txt_tim_nv_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.but_tim_nv);
            this.panel5.Controls.Add(this.txt_tim_nv);
            this.panel5.Location = new System.Drawing.Point(9, 357);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 50);
            this.panel5.TabIndex = 4;
            // 
            // user_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Name = "user_nhanvien";
            this.Size = new System.Drawing.Size(854, 420);
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_sua_nv;
        private System.Windows.Forms.DataGridView data_nv;
        private System.Windows.Forms.Button but_them_nv;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button but_xoa_nv;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button but_tim_nv;
        private System.Windows.Forms.TextBox txt_tim_nv;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
    }
}
