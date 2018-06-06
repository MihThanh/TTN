using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace all_option
{
    public partial class hethong : Form
    {
        public hethong()
        {
            InitializeComponent();
        }

        private void but_nv_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_nhanvien.Instance))
            {
                panel.Controls.Add(user_nhanvien.Instance);
                user_nhanvien.Instance.Dock = DockStyle.Fill;
                user_nhanvien.Instance.BringToFront();
            }
            else
                user_nhanvien.Instance.BringToFront();
        }

        private void but_phongban_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(user_phongban.Instance))
            {
                panel.Controls.Add(user_phongban.Instance);
                user_phongban.Instance.Dock = DockStyle.Fill;
                user_phongban.Instance.BringToFront();
            }
            else
                user_phongban.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO dbo.DUAN(MADA,TENDA,MAPB,DIADIEM) VALUES('"+txt_da_ma+"', N'"+txt_da_ten+"', '"+txt_da_mapb+"',N'"+txt_da_dd+"')";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string sua = "UPDATE DUAN SET DIADIEM = N'" + txt_da_dd + "',MAPB = '" +txt_da_mapb + "',TENDA = N'" + txt_da_ten.Text + "' WHERE MADA ='"+txt_da_ma.Text+"'";
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
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string xoa = "DELETE DUAN WHERE MADA = '" + txt_da_ma.Text + "'";
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
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO dbo.PHANCONG(MANV,MADA,SOGIO) VALUES('"+txt_pc_manv.Text+"', '"+txt_pc_mada.Text+"', "+txt_pc_sogio.Text+")";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                ketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được, hãy thử lại!");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string sua = "UPDATE PHANCONG SET SOGIO = "+txt_pc_sogio.Text+" WHERE MADA='"+txt_pc_mada.Text+"' and MANV='"+txt_pc_manv.Text+"'";
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
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string xoa = "DELETE PHANCONG WHERE MADA = '" + txt_da_ma.Text + "' AND MANV='"+txt_pc_manv.Text+"'";
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
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Close();
            }
        }
    }
}
