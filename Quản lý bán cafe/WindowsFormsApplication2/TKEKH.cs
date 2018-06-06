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
namespace WindowsFormsApplication2
{
    public partial class TKEKH : Form
    {
        public TKEKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
            con.Open();
            string sql_sp = "SELECT hoadonban.makh, khachhang.tenkh FROM hoadonban INNER JOIN khachhang ON hoadonban.makh = khachhang.makh where hoadonban.ngayban BETWEEN '" + d1.Text + "' AND '" + d2.Text + "' group by hoadonban.makh, khachhang.tenkh";
            SqlCommand com = new SqlCommand(sql_sp, con);
            com.ExecuteNonQuery();
            SqlCommand coma = new SqlCommand(sql_sp, con);
            SqlDataAdapter data = new SqlDataAdapter(coma);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            dataGridView1.DataSource = table;
        }
    }
}
