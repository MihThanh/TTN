namespace WindowsFormsApplication2
{
    partial class CTHDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTHDB));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cthdb_tt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cthdb_sl = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt_cthdb_masp = new System.Windows.Forms.TextBox();
            this.txt_cthdb_ma = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cthdb_dg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.but_tim_nv = new System.Windows.Forms.Button();
            this.txt_tim_sp = new System.Windows.Forms.TextBox();
            this.mahdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn";
            // 
            // txt_cthdb_tt
            // 
            this.txt_cthdb_tt.Location = new System.Drawing.Point(107, 220);
            this.txt_cthdb_tt.Name = "txt_cthdb_tt";
            this.txt_cthdb_tt.Size = new System.Drawing.Size(162, 20);
            this.txt_cthdb_tt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdb,
            this.masp,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 260);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thành tiền";
            // 
            // txt_cthdb_sl
            // 
            this.txt_cthdb_sl.Location = new System.Drawing.Point(107, 66);
            this.txt_cthdb_sl.Name = "txt_cthdb_sl";
            this.txt_cthdb_sl.Size = new System.Drawing.Size(162, 20);
            this.txt_cthdb_sl.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(107, 17);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(162, 20);
            this.textBox6.TabIndex = 1;
            // 
            // txt_cthdb_masp
            // 
            this.txt_cthdb_masp.Location = new System.Drawing.Point(107, 116);
            this.txt_cthdb_masp.Name = "txt_cthdb_masp";
            this.txt_cthdb_masp.Size = new System.Drawing.Size(162, 20);
            this.txt_cthdb_masp.TabIndex = 1;
            // 
            // txt_cthdb_ma
            // 
            this.txt_cthdb_ma.Location = new System.Drawing.Point(107, 17);
            this.txt_cthdb_ma.Name = "txt_cthdb_ma";
            this.txt_cthdb_ma.Size = new System.Drawing.Size(162, 20);
            this.txt_cthdb_ma.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(217, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 44);
            this.button5.TabIndex = 3;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(319, 268);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 44);
            this.button7.TabIndex = 3;
            this.button7.Text = "Xóa";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chi tiết hóa đơn bán hàng";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá";
            // 
            // txt_cthdb_dg
            // 
            this.txt_cthdb_dg.Location = new System.Drawing.Point(107, 171);
            this.txt_cthdb_dg.Name = "txt_cthdb_dg";
            this.txt_cthdb_dg.Size = new System.Drawing.Size(162, 20);
            this.txt_cthdb_dg.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_cthdb_ma);
            this.panel1.Controls.Add(this.txt_cthdb_tt);
            this.panel1.Controls.Add(this.txt_cthdb_masp);
            this.panel1.Controls.Add(this.txt_cthdb_dg);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.txt_cthdb_sl);
            this.panel1.Location = new System.Drawing.Point(11, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 263);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(324, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 320);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.but_tim_nv);
            this.panel5.Controls.Add(this.txt_tim_sp);
            this.panel5.Location = new System.Drawing.Point(11, 335);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(307, 53);
            this.panel5.TabIndex = 21;
            // 
            // but_tim_nv
            // 
            this.but_tim_nv.Image = ((System.Drawing.Image)(resources.GetObject("but_tim_nv.Image")));
            this.but_tim_nv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_tim_nv.Location = new System.Drawing.Point(6, 3);
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
            // mahdb
            // 
            this.mahdb.DataPropertyName = "mahdb";
            this.mahdb.HeaderText = "Mã HĐB";
            this.mahdb.Name = "mahdb";
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã SP";
            this.masp.Name = "masp";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // CTHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 393);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Name = "CTHDB";
            this.Text = "CTHDB";
            this.Load += new System.EventHandler(this.CTHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cthdb_tt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cthdb_sl;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txt_cthdb_masp;
        private System.Windows.Forms.TextBox txt_cthdb_ma;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cthdb_dg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button but_tim_nv;
        private System.Windows.Forms.TextBox txt_tim_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}