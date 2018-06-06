using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace all_option
{
    public partial class hethong : Form
    {
        public hethong()
        {
            InitializeComponent();
        }

        private void but_nv_Click(object sender, EventArgs e)
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

        private void but_phongban_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_phongban.Instance))
            {
                panel.Controls.Add(user_phongban.Instance);
                user_phongban.Instance.Dock = DockStyle.Fill;
                user_phongban.Instance.BringToFront();
            }
            else
                user_phongban.Instance.BringToFront();
        }
    }
}
