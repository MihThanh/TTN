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
    public partial class TKESP : Form
    {
        public TKESP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=bancafe;Integrated Security=True");
            con.Open();
            string sql_sp = "select ct_hoadonban.masp,sum(ct_hoadonban.soluong) as SL from hoadonban inner join ct_hoadonban on hoadonban.mahdb=ct_hoadonban.mahdb where hoadonban.ngayban between '" + d1.Text + "' and '" + d2.Text + "' group by ct_hoadonban.masp";
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
