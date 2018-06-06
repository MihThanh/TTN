namespace WindowsFormsApplication2
{
    partial class user_kh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_kh));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_sua = new System.Windows.Forms.Button();
            this.but_them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_ns = new System.Windows.Forms.DateTimePicker();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_kh_ten = new System.Windows.Forms.TextBox();
            this.txt_kh_ma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_thongke = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.but_tim_nv = new System.Windows.Forms.Button();
            this.txt_tim_sp = new System.Windows.Forms.TextBox();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.diachi,
            this.ngaysinh,
            this.sdt});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 223);
            this.dataGridView1.TabIndex = 12;
            // 
            // but_xoa
            // 
            this.but_xoa.Location = new System.Drawing.Point(324, 230);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(85, 44);
            this.but_xoa.TabIndex = 9;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = true;
            this.but_xoa.Click += new System.EventHandler(this.but_xoa_Click);
            // 
            // but_sua
            // 
            this.but_sua.Location = new System.Drawing.Point(194, 230);
            this.but_sua.Name = "but_sua";
            this.but_sua.Size = new System.Drawing.Size(85, 44);
            this.but_sua.TabIndex = 10;
            this.but_sua.Text = "Sửa";
            this.but_sua.UseVisualStyleBackColor = true;
            this.but_sua.Click += new System.EventHandler(this.but_sua_Click);
            // 
            // but_them
            // 
            this.but_them.Location = new System.Drawing.Point(64, 230);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(85, 44);
            this.but_them.TabIndex = 10;
            this.but_them.Text = "Thêm";
            this.but_them.UseVisualStyleBackColor = true;
            this.but_them.Click += new System.EventHandler(this.but_them_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.date_ns);
            this.panel1.Controls.Add(this.txt_sdt);
            this.panel1.Controls.Add(this.txt_diachi);
            this.panel1.Controls.Add(this.txt_kh_ten);
            this.panel1.Controls.Add(this.txt_kh_ma);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 227);
            this.panel1.TabIndex = 13;
            // 
            // date_ns
            // 
            this.date_ns.Location = new System.Drawing.Point(122, 150);
            this.date_ns.Name = "date_ns";
            this.date_ns.Size = new System.Drawing.Size(188, 20);
            this.date_ns.TabIndex = 13;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(122, 194);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(188, 20);
            this.txt_sdt.TabIndex = 11;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(122, 106);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(188, 20);
            this.txt_diachi.TabIndex = 11;
            // 
            // txt_kh_ten
            // 
            this.txt_kh_ten.Location = new System.Drawing.Point(122, 62);
            this.txt_kh_ten.Name = "txt_kh_ten";
            this.txt_kh_ten.Size = new System.Drawing.Size(188, 20);
            this.txt_kh_ten.TabIndex = 11;
            // 
            // txt_kh_ma
            // 
            this.txt_kh_ma.Location = new System.Drawing.Point(122, 16);
            this.txt_kh_ma.Name = "txt_kh_ma";
            this.txt_kh_ma.Size = new System.Drawing.Size(188, 20);
            this.txt_kh_ma.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.but_sua);
            this.panel2.Controls.Add(this.but_them);
            this.panel2.Controls.Add(this.but_xoa);
            this.panel2.Location = new System.Drawing.Point(349, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 281);
            this.panel2.TabIndex = 14;
            // 
            // but_thongke
            // 
            this.but_thongke.Location = new System.Drawing.Point(33, 3);
            this.but_thongke.Name = "but_thongke";
            this.but_thongke.Size = new System.Drawing.Size(133, 23);
            this.but_thongke.TabIndex = 22;
            this.but_thongke.Text = "Thống kê khách hàng";
            this.but_thongke.UseVisualStyleBackColor = true;
            this.but_thongke.Click += new System.EventHandler(this.but_thongke_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.but_tim_nv);
            this.panel5.Controls.Add(this.txt_tim_sp);
            this.panel5.Location = new System.Drawing.Point(26, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 48);
            this.panel5.TabIndex = 23;
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
            // txt_tim_sp
            // 
            this.txt_tim_sp.Location = new System.Drawing.Point(107, 14);
            this.txt_tim_sp.Name = "txt_tim_sp";
            this.txt_tim_sp.Size = new System.Drawing.Size(174, 20);
            this.txt_tim_sp.TabIndex = 0;
            this.txt_tim_sp.TextChanged += new System.EventHandler(this.txt_tim_sp_TextChanged);
            // 
            // makh
            // 
            this.makh.DataPropertyName = "MAKH";
            this.makh.HeaderText = "Mã KH";
            this.makh.Name = "makh";
            // 
            // tenkh
            // 
            this.tenkh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tenkh.DataPropertyName = "TENKH";
            this.tenkh.HeaderText = "Tên KH";
            this.tenkh.Name = "tenkh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "DIACHI";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "NGAYSINH";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            // 
            // user_kh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.but_thongke);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "user_kh";
            this.Size = new System.Drawing.Size(841, 340);
            this.Load += new System.EventHandler(this.user_kh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.Button but_sua;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_kh_ten;
        private System.Windows.Forms.TextBox txt_kh_ma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button but_thongke;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_ns;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button but_tim_nv;
        private System.Windows.Forms.TextBox txt_tim_sp;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}
