﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class user_kh : UserControl
    {
        public user_kh()
        {
            InitializeComponent();
            ketnoi();
            load();
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
        private void ketnoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe2;Integrated Security=True");
                con.Open();
                string sql = "SELECT * FROM khachhang";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataAdapter data = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                data.Fill(table);
                con.Close();
                dataGridView1.DataSource = table;
            }
            catch (Exception)
            {

                MessageBox.Show("Kết nối thất bại!");
            }

        }
        private void load()
        {
            txt_kh_ma.DataBindings.Add("Text", dataGridView1.DataSource, "makh");
            txt_kh_ten.DataBindings.Add("Text", dataGridView1.DataSource, "tenkh");
            txt_diachi.DataBindings.Add("Text", dataGridView1.DataSource, "diachi");
            date_ns.DataBindings.Add("Text", dataGridView1.DataSource, "ngaysinh");
            txt_sdt.DataBindings.Add("Text", dataGridView1.DataSource, "sdt");
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe2;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO khachhang(makh,tenkh) VALUES('" + txt_kh_ma.Text + "',N'" + txt_kh_ten.Text + "')";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                com_them.Dispose();
                ketnoi();
                con.Close();

                MessageBox.Show("Đã thêm thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được! Hãy thử lại.");
            }
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe2;Integrated Security=True");
                con.Open();
                string sua = "update khachhang set  tenkh='" + txt_kh_ten.Text + "'  where makh ='" + txt_kh_ma.Text + "'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                com_sua.Dispose();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã sửathành công !");
            }
            catch
            {
                MessageBox.Show("Không sửa được! Hãy thử lại.");
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe2;Integrated Security=True");
                con.Open();
                string xoa = "delete khachhang where makh='" + txt_kh_ma.Text + "' ";
                SqlCommand com_xoa = new SqlCommand(xoa, con);
                com_xoa.ExecuteNonQuery();
                com_xoa.Dispose();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã xóa thành công !");
            }
            catch
            {
                MessageBox.Show("Không sửa được! Hãy thử lại.");
            }
        }

        private void but_tim_nv_Click(object sender, EventArgs e)
        {
            TKEKH f1 = new TKEKH();
            f1.Show();
        }

        private void but_thongke_Click(object sender, EventArgs e)
        {
            TKEKH f1 = new TKEKH();
            f1.Show();
        }

        private void user_kh_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_tim_sp_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe2;Integrated Security=True");
            con.Open();
            string timkiem = "select * from khachhang where makh LIKE '%" + txt_tim_sp.Text + "%'";
            SqlCommand com_tim = new SqlCommand(timkiem, con);
            SqlDataAdapter data = new SqlDataAdapter(com_tim);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            dataGridView1.DataSource = table;
        }
    }
}
