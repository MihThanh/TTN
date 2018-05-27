using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tv
{
    public partial class f_dangki : Form
    {
        public f_dangki()
        {
            InitializeComponent();
        }

        private void but_taotk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=TAIKHOAN;Integrated Security=True");
                con.Open();
                string them = ("INSERT INTO ACCOUNT(TAIKHOAN, MATKHAU, TENHIENTHI) VALUES(N'" + txt_tao_tk.Text + "', '" + txt_tao_mk.Text + "', N'" + txt_tenhienthi.Text + "')");
                SqlCommand com = new SqlCommand(them, con);
                SqlDataReader data = com.ExecuteReader();
                MessageBox.Show("Đã thêm thành công!", "Thông báo");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi! Không thể tạo tài khoản!", "Thông báo");
            }
        }
    }
}
