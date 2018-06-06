namespace tv
{
    partial class user_thanhtoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.but_xoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mahdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_thanhtoan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.com_gia = new System.Windows.Forms.ComboBox();
            this.date_ngayxuat = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.com_kh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.com_manv = new System.Windows.Forms.ComboBox();
            this.txt_mahdb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.com_loai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.com_hang = new System.Windows.Forms.ComboBox();
            this.num_soluong = new System.Windows.Forms.NumericUpDown();
            this.but_them = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.but_kh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 438);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 430);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.but_xoa);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.but_thanhtoan);
            this.panel3.Location = new System.Drawing.Point(295, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 421);
            this.panel3.TabIndex = 17;
            // 
            // but_xoa
            // 
            this.but_xoa.Location = new System.Drawing.Point(98, 361);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(88, 45);
            this.but_xoa.TabIndex = 6;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdb,
            this.hang,
            this.loai,
            this.tenkh,
            this.manv,
            this.ngayxuat,
            this.soluong,
            this.thanhtien});
            this.dataGridView1.Location = new System.Drawing.Point(5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // mahdb
            // 
            this.mahdb.DataPropertyName = "mahdb";
            this.mahdb.HeaderText = "Mã HĐB";
            this.mahdb.Name = "mahdb";
            // 
            // hang
            // 
            this.hang.DataPropertyName = "hang";
            this.hang.HeaderText = "Hãng TV";
            this.hang.Name = "hang";
            this.hang.ReadOnly = true;
            // 
            // loai
            // 
            this.loai.DataPropertyName = "loai";
            this.loai.HeaderText = "Loại ";
            this.loai.Name = "loai";
            this.loai.ReadOnly = true;
            // 
            // tenkh
            // 
            this.tenkh.HeaderText = "Tên KH";
            this.tenkh.Name = "tenkh";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Tên NV";
            this.manv.Name = "manv";
            // 
            // ngayxuat
            // 
            this.ngayxuat.DataPropertyName = "ngayxuat";
            this.ngayxuat.HeaderText = "Ngày xuất";
            this.ngayxuat.Name = "ngayxuat";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // but_thanhtoan
            // 
            this.but_thanhtoan.Location = new System.Drawing.Point(263, 361);
            this.but_thanhtoan.Name = "but_thanhtoan";
            this.but_thanhtoan.Size = new System.Drawing.Size(94, 45);
            this.but_thanhtoan.TabIndex = 5;
            this.but_thanhtoan.Text = "Thanh toán";
            this.but_thanhtoan.UseVisualStyleBackColor = true;
            this.but_thanhtoan.Click += new System.EventHandler(this.but_thanhtoan_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.com_gia);
            this.panel4.Controls.Add(this.date_ngayxuat);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.com_kh);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.com_manv);
            this.panel4.Controls.Add(this.txt_mahdb);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.com_loai);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.com_hang);
            this.panel4.Controls.Add(this.num_soluong);
            this.panel4.Controls.Add(this.but_them);
            this.panel4.Controls.Add(this.listView2);
            this.panel4.Location = new System.Drawing.Point(5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 421);
            this.panel4.TabIndex = 16;
            // 
            // com_gia
            // 
            this.com_gia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.com_gia.Enabled = false;
            this.com_gia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.com_gia.FormattingEnabled = true;
            this.com_gia.Location = new System.Drawing.Point(109, 340);
            this.com_gia.Name = "com_gia";
            this.com_gia.Size = new System.Drawing.Size(146, 21);
            this.com_gia.TabIndex = 19;
            // 
            // date_ngayxuat
            // 
            this.date_ngayxuat.CustomFormat = "MM/dd/yyyy";
            this.date_ngayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngayxuat.Location = new System.Drawing.Point(109, 255);
            this.date_ngayxuat.Name = "date_ngayxuat";
            this.date_ngayxuat.Size = new System.Drawing.Size(148, 20);
            this.date_ngayxuat.TabIndex = 17;
            this.date_ngayxuat.Value = new System.DateTime(2018, 6, 4, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tên KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên NV";
            // 
            // com_kh
            // 
            this.com_kh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_kh.FormattingEnabled = true;
            this.com_kh.Location = new System.Drawing.Point(109, 209);
            this.com_kh.Name = "com_kh";
            this.com_kh.Size = new System.Drawing.Size(146, 21);
            this.com_kh.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày xuất";
            // 
            // com_manv
            // 
            this.com_manv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_manv.FormattingEnabled = true;
            this.com_manv.Location = new System.Drawing.Point(109, 160);
            this.com_manv.Name = "com_manv";
            this.com_manv.Size = new System.Drawing.Size(146, 21);
            this.com_manv.TabIndex = 14;
            // 
            // txt_mahdb
            // 
            this.txt_mahdb.Location = new System.Drawing.Point(109, 14);
            this.txt_mahdb.Name = "txt_mahdb";
            this.txt_mahdb.Size = new System.Drawing.Size(148, 20);
            this.txt_mahdb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã HĐB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hãng TV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đơn giá";
            // 
            // com_loai
            // 
            this.com_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_loai.FormattingEnabled = true;
            this.com_loai.Location = new System.Drawing.Point(109, 105);
            this.com_loai.Name = "com_loai";
            this.com_loai.Size = new System.Drawing.Size(146, 21);
            this.com_loai.TabIndex = 3;
            this.com_loai.SelectedIndexChanged += new System.EventHandler(this.com_loai_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng";
            // 
            // com_hang
            // 
            this.com_hang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_hang.FormattingEnabled = true;
            this.com_hang.Location = new System.Drawing.Point(109, 58);
            this.com_hang.Name = "com_hang";
            this.com_hang.Size = new System.Drawing.Size(146, 21);
            this.com_hang.TabIndex = 3;
            this.com_hang.SelectedIndexChanged += new System.EventHandler(this.com_hang_SelectedIndexChanged);
            // 
            // num_soluong
            // 
            this.num_soluong.Location = new System.Drawing.Point(109, 298);
            this.num_soluong.Name = "num_soluong";
            this.num_soluong.Size = new System.Drawing.Size(51, 20);
            this.num_soluong.TabIndex = 2;
            this.num_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // but_them
            // 
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_them.Location = new System.Drawing.Point(83, 378);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(77, 22);
            this.but_them.TabIndex = 1;
            this.but_them.Text = "Thêm";
            this.but_them.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(5, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(268, 402);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // but_kh
            // 
            this.but_kh.Location = new System.Drawing.Point(19, 2);
            this.but_kh.Name = "but_kh";
            this.but_kh.Size = new System.Drawing.Size(73, 23);
            this.but_kh.TabIndex = 1;
            this.but_kh.Text = "Thêm KH";
            this.but_kh.UseVisualStyleBackColor = true;
            this.but_kh.Click += new System.EventHandler(this.but_kh_Click);
            // 
            // user_thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.but_kh);
            this.Controls.Add(this.panel1);
            this.Name = "user_thanhtoan";
            this.Size = new System.Drawing.Size(786, 505);
            this.Load += new System.EventHandler(this.u1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_thanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox com_gia;
        private System.Windows.Forms.DateTimePicker date_ngayxuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox com_kh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox com_manv;
        private System.Windows.Forms.TextBox txt_mahdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox com_loai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox com_hang;
        private System.Windows.Forms.NumericUpDown num_soluong;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button but_kh;



    }
}
