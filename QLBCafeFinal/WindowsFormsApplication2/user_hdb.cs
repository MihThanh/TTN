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
    public partial class user_hdb : UserControl
    {
        public user_hdb()
        {
            InitializeComponent();
            ketnoi();
            load();
        }
        private static user_hdb _instance;
        public static user_hdb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_hdb();
                return _instance;
            }
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sql = "SELECT * FROM hoadonban";
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
            txt_hdb_ma.DataBindings.Add("Text", dataGridView1.DataSource, "mahdb");
            txt_hdb_makh.DataBindings.Add("Text", dataGridView1.DataSource, "makh");
            txt_hdb_manv.DataBindings.Add("Text", dataGridView1.DataSource, "manv");
            txt_hdb_ngay.DataBindings.Add("Text", dataGridView1.DataSource, "ngayban");
            txt_hdb_tien.DataBindings.Add("Text", dataGridView1.DataSource, "tongtien");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO hoadonban (mahdb,ngayban,tongtien ,manv,makh) VALUES ('" + txt_hdb_ma.Text + "','" + txt_hdb_ngay.Text + "'," + txt_hdb_tien.Text + ",'" + txt_hdb_manv.Text + "','" + txt_hdb_makh.Text + "')";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sua = "update hoadonban set manv = '" + txt_hdb_manv.Text + "',makh = '" + txt_hdb_makh.Text + "',ngayban = '" + txt_hdb_ngay.Text + "',tongtien= " + txt_hdb_tien.Text + " where mahdb = '" + txt_hdb_ma.Text + "'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã sửathành công !");
            }
            catch
            {
                MessageBox.Show("Không sửa được! Hãy thử lại.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string xoa = "delete hoadonban where mahdb='" + txt_hdb_ma.Text + "'";
                SqlCommand com_xoa = new SqlCommand(xoa, con);
                com_xoa.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã sửathành công !");
            }
            catch
            {
                MessageBox.Show("Không sửa được! Hãy thử lại.");
            }
        }

        private void but_chitiethdb_Click(object sender, EventArgs e)
        {
            CTHDB f1 = new CTHDB();
            f1.Show();
        }

      

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sua = "exec Tinh_Tien_HDB @ma='" + txt_hdb_ma.Text + "'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                ketnoi();
                con.Close();
                MessageBox.Show("Đã tính !");
            }
            catch
            {
                MessageBox.Show("Không tính được! Hãy thử lại.");
            }

        }
    }
}
