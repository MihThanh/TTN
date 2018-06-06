using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tv
{
    public partial class f_hdb : Form
    {
        public f_hdb()
        {
            InitializeComponent();
        }

        private void but_tim_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            string sql = "select * from HOADONBAN where MAHDBAN = '"+txt_mahd.Text.Trim()+"'";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string sql = "update HOADONBAN set MANV = '" + dataGridView1.Rows[i].Cells["manv"].Value + "', MAKH = '" + dataGridView1.Rows[i].Cells["makh"].Value + "',NGAYXUAT = '" + dataGridView1.Rows[i].Cells["ngayxuat"].Value + "', MASP = '" + dataGridView1.Rows[i].Cells["masp"].Value + "', SOLUONG= '" + dataGridView1.Rows[i].Cells["soluong"].Value + "', GTBAN = '" + dataGridView1.Rows[i].Cells["gtban"].Value + "' where MAHDBAN = '" + txt_mahd.Text.Trim() + "'";
                SqlCommand com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Đã sửa thành công");
        }
    }
}
