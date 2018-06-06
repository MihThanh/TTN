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

namespace all_option
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
        private void user_nhanvien_Load(object sender, EventArgs e)
        {

        }
        void ketnoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=QUANLYNHANSU;Integrated Security=True");
            con.Open();
            string sql_sp = "select * from nhanvien";
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
            txt_mangs.DataBindings.Add("Text", data_nv.DataSource, "MANGS");
            date_ns.DataBindings.Add("Text", data_nv.DataSource, "NS");
            combo_gt.DataBindings.Add("Text", data_nv.DataSource, "GT");
            txt_luong.DataBindings.Add("Text", data_nv.DataSource, "LUONG");
            txt_mapb.DataBindings.Add("Text", data_nv.DataSource, "MAPB");
        }
        private void but_them_ncc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string them = "insert into NHANVIEN(MANV, HOTEN, MANGS, NS, GT, LUONG, MAPB) values('" + txt_manv.Text + "', N'" + txt_tennv.Text + "','" + txt_mangs.Text + "', '" + date_ns.Text + "', '" + combo_gt.Text + "', '"+txt_luong.Text+"', '"+txt_mapb.Text+"')";
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

        private void but_sua_ncc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string sua = "update NHANVIEN set HOTEN = '" + txt_tennv.Text + "', MANGS = '" + txt_mangs.Text + "', NS = '" + date_ns.Text + "', GT= '" + combo_gt.Text + "', LUONG = '" + txt_luong.Text + "', MAPB = '"+txt_mapb.Text+"' where MANV = '"+txt_manv.Text.Trim()+"'";
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
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        private void but_xoa_ncc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string xoa = "delete NHANVIEN where MANV = '" + txt_manv.Text.Trim() + "'";
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
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        private void txt_tim_ncc_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=QUANLYNHANSU;Integrated Security=True");
            con.Open();
            string timkiem = "select * from NHANVIEN where MANV LIKE '%" + txt_tim_ncc.Text + "%'";
            SqlCommand com_tim = new SqlCommand(timkiem, con);
            SqlDataAdapter data = new SqlDataAdapter(com_tim);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            data_nv.DataSource = table;
        }
    }
}
