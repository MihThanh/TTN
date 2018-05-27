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
    public partial class f_themncc : Form
    {
        public f_themncc()
        {
            InitializeComponent();
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string them = "EXEC Them_ncc @ma='"+ txt_ma.Text +"',@ten='"+ txt_ten.Text +"',@diachi='"+ txt_diachi.Text +"',@sdt='"+ txt_dienthoai.Text +"'";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                com_them.Dispose();
                con.Close();
                MessageBox.Show("Đã thêm thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được! Hãy thử lại.");
            }
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
