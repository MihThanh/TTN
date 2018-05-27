namespace tv
{
    partial class user_thongke
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.data_thongke = new System.Windows.Forms.DataGridView();
            this.but_thongke = new System.Windows.Forms.Button();
            this.date_last = new System.Windows.Forms.DateTimePicker();
            this.date_first = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(54, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 409);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.data_thongke);
            this.panel2.Controls.Add(this.but_thongke);
            this.panel2.Controls.Add(this.date_last);
            this.panel2.Controls.Add(this.date_first);
            this.panel2.Location = new System.Drawing.Point(10, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 399);
            this.panel2.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(394, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Đến:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Từ:";
            // 
            // data_thongke
            // 
            this.data_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_thongke.Location = new System.Drawing.Point(10, 44);
            this.data_thongke.Name = "data_thongke";
            this.data_thongke.Size = new System.Drawing.Size(640, 342);
            this.data_thongke.TabIndex = 13;
            // 
            // but_thongke
            // 
            this.but_thongke.Location = new System.Drawing.Point(280, 2);
            this.but_thongke.Name = "but_thongke";
            this.but_thongke.Size = new System.Drawing.Size(75, 32);
            this.but_thongke.TabIndex = 12;
            this.but_thongke.Text = "Thống kê";
            this.but_thongke.UseVisualStyleBackColor = true;
            this.but_thongke.Click += new System.EventHandler(this.but_thongke_Click);
            // 
            // date_last
            // 
            this.date_last.CustomFormat = "MM/dd/yyyy";
            this.date_last.Location = new System.Drawing.Point(437, 10);
            this.date_last.Name = "date_last";
            this.date_last.Size = new System.Drawing.Size(191, 20);
            this.date_last.TabIndex = 10;
            // 
            // date_first
            // 
            this.date_first.CustomFormat = "MM/dd/yyyy";
            this.date_first.Location = new System.Drawing.Point(45, 8);
            this.date_first.Name = "date_first";
            this.date_first.Size = new System.Drawing.Size(191, 20);
            this.date_first.TabIndex = 11;
            this.date_first.Value = new System.DateTime(2018, 5, 16, 0, 0, 0, 0);
            // 
            // user_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "user_thongke";
            this.Size = new System.Drawing.Size(836, 436);
            this.Load += new System.EventHandler(this.user_thongke_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_thongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView data_thongke;
        private System.Windows.Forms.Button but_thongke;
        private System.Windows.Forms.DateTimePicker date_last;
        private System.Windows.Forms.DateTimePicker date_first;


    }
}
