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

namespace WindowsFormsApplication2
{
    public partial class NCC : UserControl
    {
        private static NCC _instance;
        public static NCC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NCC();
                return _instance;
            }
        }
        public NCC()
        {
            InitializeComponent();
            ketnoi();
            load();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sql = "SELECT * FROM nhacc";
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
            txt_ncc_dc.DataBindings.Add("Text", dataGridView1.DataSource, "diachi");
            txt_ncc_ma.DataBindings.Add("Text", dataGridView1.DataSource, "mancc");
            txt_ncc_ten.DataBindings.Add("Text", dataGridView1.DataSource, "tenncc");
            txt_ncc_sdt.DataBindings.Add("Text", dataGridView1.DataSource, "sdt");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO nhacc (mancc,tenncc,diachi,sdt) VALUES ('" + txt_ncc_ma.Text + "',N'" + txt_ncc_ten.Text + "',N'" + txt_ncc_dc.Text + "','"+txt_ncc_sdt.Text+"')";
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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string sua = "update nhacc set tenncc = N'" + txt_ncc_ten.Text + "',diachi = N'" + txt_ncc_dc.Text + "',sdt='"+txt_ncc_sdt.Text+"' where mancc = '" + txt_ncc_ma.Text + "'";
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
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=bancafe;Integrated Security=True");
                con.Open();
                string xoa = "delete nhacc where mancc='" + txt_ncc_ma.Text + "'";
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
