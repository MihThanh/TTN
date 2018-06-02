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

namespace all_option
{
    public partial class hethong : Form
    {
        public hethong()
        {
            InitializeComponent();
            ketnoi();
            load();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login f_login = new login();
            this.Close();
            f_login.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ketnoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string sql = "SELECT * FROM NHANVIEN";
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
            txt_hoten.DataBindings.Add("Text", dataGridView1.DataSource, "HOTEN");
            com_gt.DataBindings.Add("Text", dataGridView1.DataSource, "GT");
            txt_luong.DataBindings.Add("Text", dataGridView1.DataSource, "LUONG");
            date_ns.DataBindings.Add("Text", dataGridView1.DataSource, "NS");
            txt_mapb.DataBindings.Add("Text", dataGridView1.DataSource, "MAPB");
            txt_manv.DataBindings.Add("Text", dataGridView1.DataSource, "MANV");
            txt_mangs.DataBindings.Add("Text", dataGridView1.DataSource, "MANGS");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            them f_them = new them();
            f_them.Show();
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string sua = "UPDATE dbo.NHANVIEN SET HOTEN = N'" + txt_hoten.Text + "',MANV = '" + txt_manv.Text + "',GT = N'" + com_gt.Text + "',MAPB = '" + txt_mapb.Text + "',NS = '" + date_ns.Text + "'";
                SqlCommand com_sua = new SqlCommand(sua, con);
                com_sua.ExecuteNonQuery();
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể sửa, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string xoa = "DELETE dbo.NHANVIEN WHERE MANV = '" + txt_manv.Text + "'";
                SqlCommand com_xoa = new SqlCommand(xoa, con);
                com_xoa.ExecuteNonQuery();
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlytk f_quanlytk = new quanlytk();
            f_quanlytk.Show();
        }
    }
}
