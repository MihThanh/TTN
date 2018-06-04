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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void but_dn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=TAIKHOAN;Integrated Security=True");
            try
            {
                con.Open();
                string sql = "SELECT * FROM ACCOUNT WHERE TAIKHOAN = '" + txt_tk.Text + "' and MATKHAU = '" + txt_mk.Text + "'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader data = com.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    hethong f2 = new hethong();
                    this.Hide();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!"); 
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Kết nổi thất bại!");
            }
        }

        private void txt_mk_Click(object sender, EventArgs e)
        {
            txt_mk.UseSystemPasswordChar = true;
        }

        private void link_taotk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            taotk tk = new taotk();
            tk.Show();
        }

        private void txt_tk_Click(object sender, EventArgs e)
        {
            txt_tk.Text = "";
        }

        private void txt_mk_Click_1(object sender, EventArgs e)
        {
            txt_mk.Text = "";
        }
    }
}
