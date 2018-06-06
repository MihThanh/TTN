namespace all_option
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.but_xoa_ncc = new System.Windows.Forms.Button();
            this.but_sua_ncc = new System.Windows.Forms.Button();
            this.but_them_ncc = new System.Windows.Forms.Button();
            this.data_nv = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mangs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.but_tim_ncc = new System.Windows.Forms.Button();
            this.txt_tim_ncc = new System.Windows.Forms.TextBox();
            this.date_ns = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mapb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_gt = new System.Windows.Forms.ComboBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.but_xoa_ncc);
            this.panel6.Controls.Add(this.but_sua_ncc);
            this.panel6.Controls.Add(this.but_them_ncc);
            this.panel6.Controls.Add(this.data_nv);
            this.panel6.Location = new System.Drawing.Point(284, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(483, 395);
            this.panel6.TabIndex = 9;
            // 
            // but_xoa_ncc
            // 
            this.but_xoa_ncc.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa_ncc.Image")));
            this.but_xoa_ncc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_xoa_ncc.Location = new System.Drawing.Point(334, 342);
            this.but_xoa_ncc.Name = "but_xoa_ncc";
            this.but_xoa_ncc.Size = new System.Drawing.Size(85, 44);
            this.but_xoa_ncc.TabIndex = 1;
            this.but_xoa_ncc.Text = "Xóa";
            this.but_xoa_ncc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_xoa_ncc.UseVisualStyleBackColor = true;
            this.but_xoa_ncc.Click += new System.EventHandler(this.but_xoa_ncc_Click);
            // 
            // but_sua_ncc
            // 
            this.but_sua_ncc.Image = ((System.Drawing.Image)(resources.GetObject("but_sua_ncc.Image")));
            this.but_sua_ncc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_sua_ncc.Location = new System.Drawing.Point(199, 342);
            this.but_sua_ncc.Name = "but_sua_ncc";
            this.but_sua_ncc.Size = new System.Drawing.Size(85, 44);
            this.but_sua_ncc.TabIndex = 2;
            this.but_sua_ncc.Text = "Sửa";
            this.but_sua_ncc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_sua_ncc.UseVisualStyleBackColor = true;
            this.but_sua_ncc.Click += new System.EventHandler(this.but_sua_ncc_Click);
            // 
            // but_them_ncc
            // 
            this.but_them_ncc.Image = ((System.Drawing.Image)(resources.GetObject("but_them_ncc.Image")));
            this.but_them_ncc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_them_ncc.Location = new System.Drawing.Point(65, 342);
            this.but_them_ncc.Name = "but_them_ncc";
            this.but_them_ncc.Size = new System.Drawing.Size(85, 44);
            this.but_them_ncc.TabIndex = 3;
            this.but_them_ncc.Text = "Thêm";
            this.but_them_ncc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_them_ncc.UseVisualStyleBackColor = true;
            this.but_them_ncc.Click += new System.EventHandler(this.but_them_ncc_Click);
            // 
            // data_nv
            // 
            this.data_nv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.MANGS,
            this.NS,
            this.GT,
            this.LUONG,
            this.MAPB});
            this.data_nv.Location = new System.Drawing.Point(3, 2);
            this.data_nv.Name = "data_nv";
            this.data_nv.Size = new System.Drawing.Size(475, 332);
            this.data_nv.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.combo_gt);
            this.panel7.Controls.Add(this.date_ns);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txt_mapb);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txt_luong);
            this.panel7.Controls.Add(this.txt_mangs);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.txt_tennv);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.txt_manv);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(8, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 338);
            this.panel7.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày sinh";
            // 
            // txt_mangs
            // 
            this.txt_mangs.Location = new System.Drawing.Point(94, 112);
            this.txt_mangs.Name = "txt_mangs";
            this.txt_mangs.Size = new System.Drawing.Size(164, 20);
            this.txt_mangs.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã NGS";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(96, 71);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(164, 20);
            this.txt_tennv.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên NV";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(96, 24);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(164, 20);
            this.txt_manv.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã NV";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.but_tim_ncc);
            this.panel5.Controls.Add(this.txt_tim_ncc);
            this.panel5.Location = new System.Drawing.Point(8, 348);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 50);
            this.panel5.TabIndex = 7;
            // 
            // but_tim_ncc
            // 
            this.but_tim_ncc.Image = ((System.Drawing.Image)(resources.GetObject("but_tim_ncc.Image")));
            this.but_tim_ncc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_tim_ncc.Location = new System.Drawing.Point(6, 1);
            this.but_tim_ncc.Name = "but_tim_ncc";
            this.but_tim_ncc.Size = new System.Drawing.Size(85, 44);
            this.but_tim_ncc.TabIndex = 1;
            this.but_tim_ncc.Text = "Tìm";
            this.but_tim_ncc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_tim_ncc.UseVisualStyleBackColor = true;
            // 
            // txt_tim_ncc
            // 
            this.txt_tim_ncc.Location = new System.Drawing.Point(107, 12);
            this.txt_tim_ncc.Name = "txt_tim_ncc";
            this.txt_tim_ncc.Size = new System.Drawing.Size(153, 20);
            this.txt_tim_ncc.TabIndex = 0;
            this.txt_tim_ncc.TextChanged += new System.EventHandler(this.txt_tim_ncc_TextChanged);
            // 
            // date_ns
            // 
            this.date_ns.CustomFormat = "MM/dd/yyyy";
            this.date_ns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ns.Location = new System.Drawing.Point(94, 160);
            this.date_ns.Name = "date_ns";
            this.date_ns.Size = new System.Drawing.Size(162, 20);
            this.date_ns.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giới tính";
            // 
            // txt_luong
            // 
            this.txt_luong.Location = new System.Drawing.Point(94, 258);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(164, 20);
            this.txt_luong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lương";
            // 
            // txt_mapb
            // 
            this.txt_mapb.Location = new System.Drawing.Point(97, 303);
            this.txt_mapb.Name = "txt_mapb";
            this.txt_mapb.Size = new System.Drawing.Size(164, 20);
            this.txt_mapb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã PB";
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Tên NV";
            this.HOTEN.Name = "HOTEN";
            // 
            // MANGS
            // 
            this.MANGS.DataPropertyName = "MANGS";
            this.MANGS.HeaderText = "Mã NGS";
            this.MANGS.Name = "MANGS";
            // 
            // NS
            // 
            this.NS.DataPropertyName = "NS";
            this.NS.HeaderText = "Ngày sinh";
            this.NS.Name = "NS";
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GT";
            this.GT.HeaderText = "Giới tính";
            this.GT.Name = "GT";
            // 
            // LUONG
            // 
            this.LUONG.DataPropertyName = "LUONG";
            this.LUONG.HeaderText = "Lương";
            this.LUONG.Name = "LUONG";
            // 
            // MAPB
            // 
            this.MAPB.DataPropertyName = "MAPB";
            this.MAPB.HeaderText = "Mã PB";
            this.MAPB.Name = "MAPB";
            // 
            // combo_gt
            // 
            this.combo_gt.FormattingEnabled = true;
            this.combo_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.combo_gt.Location = new System.Drawing.Point(94, 214);
            this.combo_gt.Name = "combo_gt";
            this.combo_gt.Size = new System.Drawing.Size(162, 21);
            this.combo_gt.TabIndex = 5;
            // 
            // user_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Name = "user_nhanvien";
            this.Size = new System.Drawing.Size(810, 405);
            this.Load += new System.EventHandler(this.user_nhanvien_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button but_xoa_ncc;
        private System.Windows.Forms.Button but_sua_ncc;
        private System.Windows.Forms.Button but_them_ncc;
        private System.Windows.Forms.DataGridView data_nv;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_mangs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button but_tim_ncc;
        private System.Windows.Forms.TextBox txt_tim_ncc;
        private System.Windows.Forms.DateTimePicker date_ns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mapb;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPB;
        private System.Windows.Forms.ComboBox combo_gt;
    }
}
