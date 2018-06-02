namespace all_option
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.but_dn = new System.Windows.Forms.Button();
            this.link_taotk = new System.Windows.Forms.LinkLabel();
            this.txt_mk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(82, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(82, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 34);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // txt_tk
            // 
            this.txt_tk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_tk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(139, 155);
            this.txt_tk.Multiline = true;
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(237, 23);
            this.txt_tk.TabIndex = 0;
            this.txt_tk.Click += new System.EventHandler(this.txt_tk_Click);
            // 
            // but_dn
            // 
            this.but_dn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.but_dn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dn.ForeColor = System.Drawing.SystemColors.Info;
            this.but_dn.Location = new System.Drawing.Point(158, 251);
            this.but_dn.Name = "but_dn";
            this.but_dn.Size = new System.Drawing.Size(171, 42);
            this.but_dn.TabIndex = 3;
            this.but_dn.Text = "Đăng nhập";
            this.but_dn.UseVisualStyleBackColor = false;
            this.but_dn.Click += new System.EventHandler(this.but_dn_Click);
            // 
            // link_taotk
            // 
            this.link_taotk.AutoSize = true;
            this.link_taotk.BackColor = System.Drawing.Color.Transparent;
            this.link_taotk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_taotk.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_taotk.LinkColor = System.Drawing.Color.Brown;
            this.link_taotk.Location = new System.Drawing.Point(199, 306);
            this.link_taotk.Name = "link_taotk";
            this.link_taotk.Size = new System.Drawing.Size(81, 15);
            this.link_taotk.TabIndex = 5;
            this.link_taotk.TabStop = true;
            this.link_taotk.Text = "Tạo tài khoản";
            this.link_taotk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_taotk_LinkClicked);
            // 
            // txt_mk
            // 
            this.txt_mk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk.Location = new System.Drawing.Point(139, 208);
            this.txt_mk.Multiline = true;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(237, 23);
            this.txt_mk.TabIndex = 1;
            this.txt_mk.UseSystemPasswordChar = true;
            this.txt_mk.Click += new System.EventHandler(this.txt_mk_Click_1);
            // 
            // login
            // 
            this.AcceptButton = this.but_dn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(489, 335);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.link_taotk);
            this.Controls.Add(this.but_dn);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "Phần mềm quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Button but_dn;
        private System.Windows.Forms.LinkLabel link_taotk;
        private System.Windows.Forms.TextBox txt_mk;
    }
}

