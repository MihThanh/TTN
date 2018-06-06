using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tv
{
    public partial class user_kh : UserControl
    {
        public user_kh()
        {
            InitializeComponent();
            ketnoi();
            load();
        }

        private void user_kh_Load(object sender, EventArgs e)
        {
        }
        private static user_kh _instance;
        public static user_kh Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_kh();
                return _instance;
            }
        }
        void ketnoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            string sql_sp = "select * from KHACHHANG";
            SqlCommand com = new SqlCommand(sql_sp, con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            data_nhacc.DataSource = table;
        }
        private void load()
        {
            txt_masncc.DataBindings.Add("Text", data_nhacc.DataSource, "MAKH");
            txt_diachi.DataBindings.Add("Text", data_nhacc.DataSource, "DIACHI");
            txt_tenncc.DataBindings.Add("Text", data_nhacc.DataSource, "TENKH");
            txt_sdt.DataBindings.Add("Text", data_nhacc.DataSource, "SDT");
        }
        private void but_sua_ncc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string them = "insert into KHACHHANG(MAKH, TENKH, DIACHI, SDT) values('"+txt_masncc.Text+"', N'"+txt_tenncc.Text+"', N'"+txt_diachi.Text+"', '"+txt_sdt.Text+"')";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                com_them.Dispose();
                con.Close();
                MessageBox.Show("Đã thêm thành công!");
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được! Hãy thử lại.");
            }
        }

        private void but_xoa_ncc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string them = "delete KHACHHANG where MAKH = '"+txt_masncc.Text.Trim()+"'";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                com_them.Dispose();
                con.Close();
                MessageBox.Show("Đã xóa thành công!");
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được! Hãy thử lại.");
            }
        }

        private void txt_tim_ncc_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            string timkiem = "select * from KHACHHANG where MAKH LIKE '%" + txt_tim_ncc.Text + "%'";
            SqlCommand com_xoa = new SqlCommand(timkiem, con);
            SqlDataAdapter data = new SqlDataAdapter(com_xoa);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            data_nhacc.DataSource = table;
        }
    }
}
