namespace all_option
{
    partial class user_phongban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_phongban));
            this.panel6 = new System.Windows.Forms.Panel();
            this.but_xoa_ncc = new System.Windows.Forms.Button();
            this.but_sua_ncc = new System.Windows.Forms.Button();
            this.but_them_ncc = new System.Windows.Forms.Button();
            this.data_nv = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tenpb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mapb1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.but_tim_ncc = new System.Windows.Forms.Button();
            this.txt_tim_ncc = new System.Windows.Forms.TextBox();
            this.txt_dd = new System.Windows.Forms.TextBox();
            this.date_ngaync = new System.Windows.Forms.DateTimePicker();
            this.MAPB1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIADIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel6.Location = new System.Drawing.Point(289, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(483, 395);
            this.panel6.TabIndex = 12;
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
            this.MAPB1,
            this.TENPB,
            this.MATP,
            this.DIADIEM,
            this.NGAYNC});
            this.data_nv.Location = new System.Drawing.Point(3, 2);
            this.data_nv.Name = "data_nv";
            this.data_nv.Size = new System.Drawing.Size(475, 332);
            this.data_nv.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.date_ngaync);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txt_dd);
            this.panel7.Controls.Add(this.txt_matp);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.txt_tenpb);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.txt_mapb1);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(13, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 338);
            this.panel7.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày NC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa điểm";
            // 
            // txt_matp
            // 
            this.txt_matp.Location = new System.Drawing.Point(96, 150);
            this.txt_matp.Name = "txt_matp";
            this.txt_matp.Size = new System.Drawing.Size(164, 20);
            this.txt_matp.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã TP";
            // 
            // txt_tenpb
            // 
            this.txt_tenpb.Location = new System.Drawing.Point(96, 89);
            this.txt_tenpb.Name = "txt_tenpb";
            this.txt_tenpb.Size = new System.Drawing.Size(164, 20);
            this.txt_tenpb.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên PB";
            // 
            // txt_mapb1
            // 
            this.txt_mapb1.Location = new System.Drawing.Point(96, 24);
            this.txt_mapb1.Name = "txt_mapb1";
            this.txt_mapb1.Size = new System.Drawing.Size(164, 20);
            this.txt_mapb1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã PB";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.but_tim_ncc);
            this.panel5.Controls.Add(this.txt_tim_ncc);
            this.panel5.Location = new System.Drawing.Point(13, 359);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 50);
            this.panel5.TabIndex = 10;
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
            // txt_dd
            // 
            this.txt_dd.Location = new System.Drawing.Point(96, 208);
            this.txt_dd.Name = "txt_dd";
            this.txt_dd.Size = new System.Drawing.Size(164, 20);
            this.txt_dd.TabIndex = 3;
            // 
            // date_ngaync
            // 
            this.date_ngaync.CustomFormat = "MM/dd/yyyy";
            this.date_ngaync.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngaync.Location = new System.Drawing.Point(96, 268);
            this.date_ngaync.Name = "date_ngaync";
            this.date_ngaync.Size = new System.Drawing.Size(164, 20);
            this.date_ngaync.TabIndex = 4;
            // 
            // MAPB1
            // 
            this.MAPB1.DataPropertyName = "MAPB";
            this.MAPB1.HeaderText = "Mã PB";
            this.MAPB1.Name = "MAPB1";
            // 
            // TENPB
            // 
            this.TENPB.DataPropertyName = "TENPB";
            this.TENPB.HeaderText = "Tên PB";
            this.TENPB.Name = "TENPB";
            // 
            // MATP
            // 
            this.MATP.DataPropertyName = "MATP";
            this.MATP.HeaderText = "Mã TP";
            this.MATP.Name = "MATP";
            // 
            // DIADIEM
            // 
            this.DIADIEM.DataPropertyName = "DIADIEM";
            this.DIADIEM.HeaderText = "Địa điểm";
            this.DIADIEM.Name = "DIADIEM";
            // 
            // NGAYNC
            // 
            this.NGAYNC.DataPropertyName = "NGAYNC";
            this.NGAYNC.HeaderText = "Ngày NC";
            this.NGAYNC.Name = "NGAYNC";
            // 
            // user_phongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Name = "user_phongban";
            this.Size = new System.Drawing.Size(810, 405);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_tenpb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mapb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button but_tim_ncc;
        private System.Windows.Forms.TextBox txt_tim_ncc;
        private System.Windows.Forms.DateTimePicker date_ngaync;
        private System.Windows.Forms.TextBox txt_dd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPB1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIADIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNC;
    }
}
