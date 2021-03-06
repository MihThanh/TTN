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
    public partial class user_loai : UserControl
    {
        private static user_loai _instance;
        public static user_loai Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_loai();
                return _instance;
            }
        }
        public user_loai()
        {
            InitializeComponent();
            ketnoi();
            load();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe2;Integrated Security=True");
                con.Open();
                string sql = "SELECT * FROM loai";
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
            txt_loai_ma.DataBindings.Add("Text", dataGridView1.DataSource, "maloai");
            txt_loai_ten.DataBindings.Add("Text", dataGridView1.DataSource, "tenloai");

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe2;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO loai (maloai,tenloai) VALUES ('" + txt_loai_ma.Text + "',N'" + txt_loai_ten.Text + "')";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã thêm thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được! Hãy thử lại.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe2;Integrated Security=True");
                con.Open();
                string sua = "update loai set tenloai=N'" + txt_loai_ten.Text + "' where maloai = '" + txt_loai_ma.Text + "'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã sửa thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được! Hãy thử lại.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe2;Integrated Security=True");
                con.Open();
                string xoa = "delete loai where maloai='" + txt_loai_ma.Text + "'";
                SqlCommand com_xoa = new SqlCommand(xoa, con);
                com_xoa.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã xóa thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được! Hãy thử lại.");
            }
        }
    }
}
