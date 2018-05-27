using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tv
{
    public partial class f_hethong : Form
    {
        public f_hethong()
        {
            InitializeComponent();
            panel.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but_thanhtoan_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_thanhtoan.Instance))
            {
                panel.Controls.Add(user_thanhtoan.Instance);
                user_thanhtoan.Instance.Dock = DockStyle.Fill;
                user_thanhtoan.Instance.BringToFront();
            }
            else
                user_thanhtoan.Instance.BringToFront();
        }

        private void but_thongke_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_thongke.Instance))
            {
                panel.Controls.Add(user_thongke.Instance);
                user_thongke.Instance.Dock = DockStyle.Fill;
                user_thongke.Instance.BringToFront();
            }
            else
                user_thongke.Instance.BringToFront();
        }

        private void but_sanpham_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_sanpham.Instance))
            {
                panel.Controls.Add(user_sanpham.Instance);
                user_sanpham.Instance.Dock = DockStyle.Fill;
                user_sanpham.Instance.BringToFront();
            }
            else
                user_sanpham.Instance.BringToFront();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f_login f1 = new f_login();
            f1.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tool_thongtin_Click(object sender, EventArgs e)
        {
            f_qltaikhoan f1 = new f_qltaikhoan();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_nhacc.Instance))
            {
                panel.Controls.Add(user_nhacc.Instance);
                user_nhacc.Instance.Dock = DockStyle.Fill;
                user_nhacc.Instance.BringToFront();
            }
            else
                user_nhacc.Instance.BringToFront();
        }

        private void but_nhanvien_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_nhanvien.Instance))
            {
                panel.Controls.Add(user_nhanvien.Instance);
                user_nhanvien.Instance.Dock = DockStyle.Fill;
                user_nhanvien.Instance.BringToFront();
            }
            else
                user_nhanvien.Instance.BringToFront();
        }


    }
}
