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
    public partial class user_sanpham : UserControl
    {
        public user_sanpham()
        {
            InitializeComponent();
            ketnoi();
            load();
        }

        private void user_sanpham_Load(object sender, EventArgs e)
        {

        }

        private static user_sanpham _instance;
        public static user_sanpham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_sanpham();
                return _instance;
            }
        }
        void ketnoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string sql_sp = "exec xemsp";
                SqlCommand com = new SqlCommand(sql_sp, con);
                SqlDataAdapter data = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                data.Fill(table);
                con.Close();
                data_sp.DataSource = table;
            }
            catch (Exception)
            {

                MessageBox.Show("Kết nối thất bại!");
            }
        }
        private void load()
        {
            txt_gia.DataBindings.Add("Text", data_sp.DataSource, "GIA");
            txt_masp.DataBindings.Add("Text", data_sp.DataSource, "MASP");
            txt_mansx.DataBindings.Add("Text", data_sp.DataSource, "MANSX");
            txt_tennsx.DataBindings.Add("Text", data_sp.DataSource, "TENNSX");
            txt_tensp.DataBindings.Add("Text", data_sp.DataSource, "TENSP");
            date_ngaynhap.DataBindings.Add("Text", data_sp.DataSource, "NGAYNHAP");
        }
        private void but_them_sp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string them = "EXEC Themsp @ma='" + txt_masp.Text + "',@ten=N'" + txt_tensp.Text + "',@gia='" + txt_gia.Text + "',@mansx='"+ txt_mansx.Text +"'";
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

        private void txt_tim_sp_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            string timkiem = "select * from SANPHAM where MASP LIKE '%" + txt_tim_sp.Text + "%'";
            SqlCommand com_tim = new SqlCommand(timkiem, con);
            SqlDataAdapter data = new SqlDataAdapter(com_tim);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            data_sp.DataSource = table;
        }

        private void but_xoa_sp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string xoa = "delete SANPHAM where MASP = '" + txt_masp.Text + "'";
                SqlCommand com_xoa = new SqlCommand(xoa, con);
                com_xoa.ExecuteNonQuery();
                com_xoa.Dispose();
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Close();
            }
        }

        private void but_sua_sp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string sua = "update sanpham set tensp = N'"+ txt_tensp.Text +"', gia ='"+ txt_gia.Text +"', mansx = '"+ txt_mansx.Text +"', ngaynhap = '"+ date_ngaynhap.Text +"' where masp = '"+ txt_masp.Text +"'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                com_sua.Dispose();
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Close();
            }
        }

        private void but_tim_sp_Click(object sender, EventArgs e)
        {

        }


    }
}
