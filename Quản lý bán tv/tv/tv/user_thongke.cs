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

namespace tv
{
    public partial class user_thongke : UserControl
    {
        public user_thongke()
        {
            InitializeComponent();
        }

        private void user_thongke_Load(object sender, EventArgs e)
        {

        }

        private static user_thongke _instance;
        public static user_thongke Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_thongke();
                return _instance;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void but_thongke_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            string sql_sp = "select * from HOADONBAN where NGAYXUAT between '" + date_first.Text + "' and '" + date_last.Text + "'";
            SqlCommand com = new SqlCommand(sql_sp, con);
            com.ExecuteNonQuery();
            SqlCommand coma = new SqlCommand(sql_sp, con);
            SqlDataAdapter data = new SqlDataAdapter(coma);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            data_thongke.DataSource = table;
        }
    }
}
