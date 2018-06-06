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
    public partial class them_kh : Form
    {
        public them_kh()
        {
            InitializeComponent();
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string sql = "insert into KHACHHANG(MAKH, TENKH, DIACHI, SDT) values('"+txt_makh.Text+"', N'"+txt_tenkh.Text+"', N'"+txt_diachi.Text+"', '"+txt_sdt.Text+"')";
                SqlCommand com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("Đã thêm thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được");
            }
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
