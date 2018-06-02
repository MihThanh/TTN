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
    public partial class them : Form
    {
        public them()
        {
            InitializeComponent();
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkL_rs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            com_gt.Text = "";
            txt_hoten.Text = "";
            txt_luong.Text = "";
            txt_mangs.Text = "";
            txt_manv.Text = "";
            txt_mapb.Text = "";
            date_ns.Text = "";
        }
        private void but_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=THANH-PC\THANH;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                con.Open();
                string them = "INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS, LUONG, MANGS) VALUES (N'" + txt_hoten.Text + "','" + txt_manv.Text + "',N'" + com_gt.Text + "','" + txt_mapb.Text + "','" + date_ns.Text + "', '"+txt_luong.Text+"', '"+txt_mangs.Text+"')";
                SqlCommand com_them = new SqlCommand(them, con);
                com_them.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Đã thêm thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được! Hãy thử lại.");
            }
        }

    }
}
