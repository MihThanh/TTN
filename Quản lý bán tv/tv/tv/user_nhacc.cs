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
    public partial class user_nhacc : UserControl
    {
        public user_nhacc()
        {
            InitializeComponent();
            ketnoi();
            load();
        }

        private static user_nhacc _instance;
        public static user_nhacc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_nhacc();
                return _instance;
            }
        }

        void ketnoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            string sql_sp = "exec xem_nhacc";
            SqlCommand com = new SqlCommand(sql_sp, con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            data_nhacc.DataSource = table;
        }
        private void load()
        {
            txt_masncc.DataBindings.Add("Text", data_nhacc.DataSource, "MANCC");
            txt_diachi.DataBindings.Add("Text", data_nhacc.DataSource, "DIACHI");
            txt_tenncc.DataBindings.Add("Text", data_nhacc.DataSource, "TENNCC");
            txt_sdt.DataBindings.Add("Text", data_nhacc.DataSource, "SDT");
        }

        private void but_them_sp_Click(object sender, EventArgs e)
        {
            //f_themncc f1 = new f_themncc();
            //f1.Show();

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string them = "EXEC Them_ncc @ma='" + txt_masncc.Text + "',@ten='" + txt_tenncc.Text + "',@diachi='" + txt_diachi.Text + "',@sdt='" + txt_sdt.Text + "'";
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

        private void but_sua_sp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string xoa = "EXEC Sua_ncc @ma='" + txt_masncc + "',@ten='" + txt_tenncc + "',@diachi='" + txt_diachi + "',@sdt='" + txt_sdt +"'";
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

        private void but_xoa_sp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string xoa = "delete NHACC where MANCC = '"+ txt_masncc.Text +"'";
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

        private void but_tim_sp_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
             con.Open();
             string timkiem = "select * from NHACC where MANCC LIKE '%"+ txt_tim_ncc.Text +"%'";
             SqlCommand com_xoa = new SqlCommand(timkiem, con);
             SqlDataAdapter data = new SqlDataAdapter(com_xoa);
             DataTable table = new DataTable();
             data.Fill(table);
             con.Close();
             data_nhacc.DataSource = table;
        }


        private void txt_tim_ncc_TextChanged(object sender, EventArgs e)
        {
              SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
              con.Open();
              string timkiem = "select * from NHACC where MANCC LIKE '%" + txt_tim_ncc.Text + "%'";
              SqlCommand com_xoa = new SqlCommand(timkiem, con);
              SqlDataAdapter data = new SqlDataAdapter(com_xoa);
              DataTable table = new DataTable();
              data.Fill(table);
              con.Close();
              data_nhacc.DataSource = table;
            }
        }
    }
