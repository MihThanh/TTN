namespace WindowsFormsApplication2
{
    partial class CTHDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTHDN));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cthdn_sl = new System.Windows.Forms.TextBox();
            this.txt_cthdn_dg = new System.Windows.Forms.TextBox();
            this.txt_cthdn_tt = new System.Windows.Forms.TextBox();
            this.txt_cthdn_ma = new System.Windows.Forms.TextBox();
            this.txt_cthdn_masp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.but_tim_nv = new System.Windows.Forms.Button();
            this.txt_tim_sp = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thành tiền";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(287, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chi tiết hóa đơn nhập hàng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_cthdn_sl
            // 
            this.txt_cthdn_sl.Location = new System.Drawing.Point(104, 68);
            this.txt_cthdn_sl.Name = "txt_cthdn_sl";
            this.txt_cthdn_sl.Size = new System.Drawing.Size(165, 20);
            this.txt_cthdn_sl.TabIndex = 3;
            // 
            // txt_cthdn_dg
            // 
            this.txt_cthdn_dg.Location = new System.Drawing.Point(104, 164);
            this.txt_cthdn_dg.Name = "txt_cthdn_dg";
            this.txt_cthdn_dg.Size = new System.Drawing.Size(165, 20);
            this.txt_cthdn_dg.TabIndex = 3;
            // 
            // txt_cthdn_tt
            // 
            this.txt_cthdn_tt.Location = new System.Drawing.Point(104, 209);
            this.txt_cthdn_tt.Name = "txt_cthdn_tt";
            this.txt_cthdn_tt.Size = new System.Drawing.Size(165, 20);
            this.txt_cthdn_tt.TabIndex = 3;
            // 
            // txt_cthdn_ma
            // 
            this.txt_cthdn_ma.Location = new System.Drawing.Point(104, 21);
            this.txt_cthdn_ma.Name = "txt_cthdn_ma";
            this.txt_cthdn_ma.Size = new System.Drawing.Size(165, 20);
            this.txt_cthdn_ma.TabIndex = 3;
            // 
            // txt_cthdn_masp
            // 
            this.txt_cthdn_masp.Location = new System.Drawing.Point(104, 117);
            this.txt_cthdn_masp.Name = "txt_cthdn_masp";
            this.txt_cthdn_masp.Size = new System.Drawing.Size(165, 20);
            this.txt_cthdn_masp.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_cthdn_dg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_cthdn_masp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_cthdn_tt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_cthdn_ma);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_cthdn_sl);
            this.panel1.Location = new System.Drawing.Point(8, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 263);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(333, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 320);
            this.panel2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.but_tim_nv);
            this.panel5.Controls.Add(this.txt_tim_sp);
            this.panel5.Location = new System.Drawing.Point(8, 319);
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
            // CTHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 381);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Name = "CTHDN";
            this.Text = "CTHDN";
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cthdn_sl;
        private System.Windows.Forms.TextBox txt_cthdn_dg;
        private System.Windows.Forms.TextBox txt_cthdn_tt;
        private System.Windows.Forms.TextBox txt_cthdn_ma;
        private System.Windows.Forms.TextBox txt_cthdn_masp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button but_tim_nv;
        private System.Windows.Forms.TextBox txt_tim_sp;
    }
}