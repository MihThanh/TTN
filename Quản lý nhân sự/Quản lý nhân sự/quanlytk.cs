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

namespace all_option
{
    public partial class quanlytk : Form
    {
        public quanlytk()
        {
            InitializeComponent();
            ketnoi();
            load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ketnoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=TAIKHOAN;Integrated Security=True");
            con.Open();
            string sql = "SELECT * FROM ACCOUNT";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            dataGridView1.DataSource = table;
        }
        private void load()
        {
            txt_mk.DataBindings.Add("Text", dataGridView1.DataSource, "MATKHAU");
            txt_tenhienthi.DataBindings.Add("Text", dataGridView1.DataSource, "TENHIENTHI");
            txt_tk.DataBindings.Add("Text", dataGridView1.DataSource, "TAIKHOAN");
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=TAIKHOAN;Integrated Security=True");
                con.Open();
                string sua = "UPDATE ACCOUNT SET MATKHAU = '"+txt_mkmoi.Text+"' WHERE TAIKHOAN = '"+txt_tk.Text+"'";
                SqlCommand com = new SqlCommand(sua, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Đã sửa thành công!");
            }
            catch (Exception)
            {
                
                MessageBox.Show("Không sửa được!");
            }
        }
    }
}
