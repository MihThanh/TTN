using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace all_option
{
    public partial class taotk : Form
    {
        public taotk()
        {
            InitializeComponent();
        }

        private void but_taotk_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=thanh-pc\thanh;Initial Catalog=account;Integrated Security=True");
            try
            {
                con.Open();
                string them_tk = "INSERT INTO nguoidung(taikhoan, matkhau, tenhienthi) VALUES('"+txt_tao_tk.Text+"','"+txt_tao_mk.Text+"', '"+txt_tenhienthi.Text+"')";
                SqlCommand com = new SqlCommand(them_tk, con);
                SqlDataReader data = com.ExecuteReader();
                MessageBox.Show("Đã thêm thành công!");
                this.Close();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Kết nối thất bại!");
            }
        }

        private void txt_tao_mk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
