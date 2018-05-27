namespace tv
{
    partial class user_nhacc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_nhacc));
            this.but_sua_ncc = new System.Windows.Forms.Button();
            this.data_nhacc = new System.Windows.Forms.DataGridView();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_them_ncc = new System.Windows.Forms.Button();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.but_xoa_ncc = new System.Windows.Forms.Button();
            this.txt_masncc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.but_tim_ncc = new System.Windows.Forms.Button();
            this.txt_tim_ncc = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.data_nhacc)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_sua_ncc
            // 
            this.but_sua_ncc.Image = ((System.Drawing.Image)(resources.GetObject("but_sua_ncc.Image")));
            this.but_sua_ncc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_sua_ncc.Location = new System.Drawing.Point(199, 340);
            this.but_sua_ncc.Name = "but_sua_ncc";
            this.but_sua_ncc.Size = new System.Drawing.Size(85, 44);
            this.but_sua_ncc.TabIndex = 2;
            this.but_sua_ncc.Text = "Sửa";
            this.but_sua_ncc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_sua_ncc.UseVisualStyleBackColor = true;
            this.but_sua_ncc.Click += new System.EventHandler(this.but_sua_sp_Click);
            // 
            // data_nhacc
            // 
            this.data_nhacc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_nhacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_nhacc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANCC,
            this.TENNCC,
            this.DIACHI,
            this.sdt});
            this.data_nhacc.Location = new System.Drawing.Point(3, 2);
            this.data_nhacc.Name = "data_nhacc";
            this.data_nhacc.Size = new System.Drawing.Size(504, 332);
            this.data_nhacc.TabIndex = 0;
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã NCC";
            this.MANCC.Name = "MANCC";
            // 
            // TENNCC
            // 
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Tên NCC";
            this.TENNCC.Name = "TENNCC";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            // 
            // but_them_ncc
            // 
            this.but_them_ncc.Image = ((System.Drawing.Image)(resources.GetObject("but_them_ncc.Image")));
            this.but_them_ncc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_them_ncc.Location = new System.Drawing.Point(65, 340);
            this.but_them_ncc.Name = "but_them_ncc";
            this.but_them_ncc.Size = new System.Drawing.Size(85, 44);
            this.but_them_ncc.TabIndex = 3;
            this.but_them_ncc.Text = "Thêm";
            this.but_them_ncc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_them_ncc.UseVisualStyleBackColor = true;
            this.but_them_ncc.Click += new System.EventHandler(this.but_them_sp_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(96, 232);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(183, 20);
            this.txt_sdt.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số điện thoại:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(96, 172);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(183, 20);
            this.txt_diachi.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Địa chỉ:";
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(98, 116);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(183, 20);
            this.txt_tenncc.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên NCC:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.but_xoa_ncc);
            this.panel6.Controls.Add(this.but_sua_ncc);
            this.panel6.Controls.Add(this.but_them_ncc);
            this.panel6.Controls.Add(this.data_nhacc);
            this.panel6.Location = new System.Drawing.Point(309, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(512, 395);
            this.panel6.TabIndex = 6;
            // 
            // but_xoa_ncc
            // 
            this.but_xoa_ncc.Image = ((System.Drawing.Image)(resources.GetObject("but_xoa_ncc.Image")));
            this.but_xoa_ncc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_xoa_ncc.Location = new System.Drawing.Point(334, 340);
            this.but_xoa_ncc.Name = "but_xoa_ncc";
            this.but_xoa_ncc.Size = new System.Drawing.Size(85, 44);
            this.but_xoa_ncc.TabIndex = 1;
            this.but_xoa_ncc.Text = "Xóa";
            this.but_xoa_ncc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_xoa_ncc.UseVisualStyleBackColor = true;
            this.but_xoa_ncc.Click += new System.EventHandler(this.but_xoa_sp_Click);
            // 
            // txt_masncc
            // 
            this.txt_masncc.Location = new System.Drawing.Point(98, 54);
            this.txt_masncc.Name = "txt_masncc";
            this.txt_masncc.Size = new System.Drawing.Size(183, 20);
            this.txt_masncc.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã NCC:";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txt_sdt);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txt_diachi);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.txt_tenncc);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.txt_masncc);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(9, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(293, 338);
            this.panel7.TabIndex = 5;
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
            this.but_tim_ncc.Click += new System.EventHandler(this.but_tim_sp_Click);
            // 
            // txt_tim_ncc
            // 
            this.txt_tim_ncc.Location = new System.Drawing.Point(107, 12);
            this.txt_tim_ncc.Name = "txt_tim_ncc";
            this.txt_tim_ncc.Size = new System.Drawing.Size(174, 20);
            this.txt_tim_ncc.TabIndex = 0;
            this.txt_tim_ncc.TextChanged += new System.EventHandler(this.txt_tim_ncc_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.but_tim_ncc);
            this.panel5.Controls.Add(this.txt_tim_ncc);
            this.panel5.Location = new System.Drawing.Point(9, 357);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 50);
            this.panel5.TabIndex = 4;
            // 
            // user_nhacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Name = "user_nhacc";
            this.Size = new System.Drawing.Size(854, 420);
            ((System.ComponentModel.ISupportInitialize)(this.data_nhacc)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_sua_ncc;
        private System.Windows.Forms.DataGridView data_nhacc;
        private System.Windows.Forms.Button but_them_ncc;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button but_xoa_ncc;
        private System.Windows.Forms.TextBox txt_masncc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button but_tim_ncc;
        private System.Windows.Forms.TextBox txt_tim_ncc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;

    }
}
