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
    public partial class user_nhanvien : UserControl
    {
        public user_nhanvien()
        {
            InitializeComponent();
            ketnoi();
            load();
        }

        private static user_nhanvien _instance;
        public static user_nhanvien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_nhanvien();
                return _instance;
            }
        }

        void ketnoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            string sql_sp = "exec xem_nhanvien";
            SqlCommand com = new SqlCommand(sql_sp, con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            data_nv.DataSource = table;
        }
        private void load()
        {
            txt_manv.DataBindings.Add("Text", data_nv.DataSource, "MANV");
            txt_tennv.DataBindings.Add("Text", data_nv.DataSource, "HOTEN");
            date_ngaysinh.DataBindings.Add("Text", data_nv.DataSource, "NGAYSINH");
            txt_sdt.DataBindings.Add("Text", data_nv.DataSource, "SDT");
        }

        //hong
        private void but_them_sp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string them = "insert into NHANVIEN(MANV, HOTEN, NGAYSINH, SDT) values('"+ txt_manv.Text +"', N'"+ txt_tennv.Text +"', '"+ date_ngaysinh.Text +"', '"+ txt_sdt.Text +"')";
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

        private void but_xoa_sp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string xoa = "delete NHANVIEN where MANV = '"+ txt_manv.Text +"'";
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

        private void txt_tim_nv_TextChanged(object sender, EventArgs e)
        {

             SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
             con.Open();
             string timkiem = "select * from NHANVIEN where MANV LIKE '%" + txt_tim_nv.Text + "%'";
             SqlCommand com_tim = new SqlCommand(timkiem, con);
             SqlDataAdapter data = new SqlDataAdapter(com_tim);
             DataTable table = new DataTable();
             data.Fill(table);
             con.Close();
             data_nv.DataSource = table;
        }

        private void but_sua_sp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string sua = "EXEC Sua_nv @ma='"+ txt_manv.Text +"',@ten=N'"+ txt_tennv.Text +"',@ngaysinh='"+ date_ngaysinh.Text +"',@sdt='"+ txt_sdt.Text +"'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                com_sua.Dispose();
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không sửa được, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Close();
            }
        }
    }
}
