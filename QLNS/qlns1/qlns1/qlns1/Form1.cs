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

namespace qlns1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi();
            load();
        }

        private void ketnoi() {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string sql = "SELECT * FROM NHANVIEN";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataAdapter data = new SqlDataAdapter(com);
                DataTable table = new DataTable();
                data.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();
            }
            catch 
            {
                MessageBox.Show("Kết nối thất bại. Hãy thử lại!");
            }
            
        }

        private void load() {
            txt_ten.DataBindings.Clear();
            txt_ten.DataBindings.Add("Text", dataGridView1.DataSource, "HOTEN");
            txt_ns.DataBindings.Clear();
            txt_ns.DataBindings.Add("Text", dataGridView1.DataSource, "NS");
            txt_mnv.DataBindings.Clear();
            txt_mnv.DataBindings.Add("Text", dataGridView1.DataSource, "MANV");
            txt_mngs.DataBindings.Clear();
            txt_mngs.DataBindings.Add("Text", dataGridView1.DataSource, "MANGS");
            txt_mapb.DataBindings.Clear();
            txt_mapb.DataBindings.Add("Text", dataGridView1.DataSource, "MAPB");
            txt_luong.DataBindings.Clear();
            txt_luong.DataBindings.Add("Text", dataGridView1.DataSource, "LUONG");
            com_gt.DataBindings.Clear();
            com_gt.DataBindings.Add("Text", dataGridView1.DataSource, "GT");
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                this.Close();
            }
        }

        string them;
        private void but_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                them = "INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) VALUES (N'" + txt_ten.Text + "','" + txt_mnv.Text + "',N'" + com_gt.Text + "','" + txt_mapb.Text + "','" + txt_ns.Text + "')";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Không thêm được, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }
        /*string sua;
        private void but_sua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                sua = "UPDATE dbo.NHANVIEN SET HOTEN = N'" + txt_ten.Text + "',MANV = '" + txt_mnv.Text + "',GT = N'" + com_gt.Text + "',MAPB = '" + txt_mapb.Text + "',NS = '"+txt_ns.Text+"'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể sửa, hãy thử lại!");
            }
            finally {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }*/

        string xoa;
        private void but_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                xoa = "DELETE dbo.NHANVIEN WHERE MANV = '" + txt_mnv.Text + "'";
                SqlCommand com_xoa = new SqlCommand(xoa , con);
                com_xoa.ExecuteNonQuery();
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được, hãy thử lại!");
            }
            finally {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

    }
}
