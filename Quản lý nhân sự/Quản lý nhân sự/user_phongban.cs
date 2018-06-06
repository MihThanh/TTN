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

namespace all_option
{
    public partial class user_phongban : UserControl
    {
        public user_phongban()
        {
            InitializeComponent();
            ketnoi();
            load();
        }
        private static user_phongban _instance;
        public static user_phongban Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_phongban();
                return _instance;
            }
        }
        private void but_them_ncc_Click(object sender, EventArgs e)
        {

        }
        void ketnoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=QUANLYNHANSU;Integrated Security=True");
            con.Open();
            string sql_sp = "select * from phongban";
            SqlCommand com = new SqlCommand(sql_sp, con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            data_nv.DataSource = table;
        }
        private void load()
        {
            txt_mapb1.DataBindings.Add("Text", data_nv.DataSource, "MAPB");
            txt_tenpb.DataBindings.Add("Text", data_nv.DataSource, "TENPB");
            txt_matp.DataBindings.Add("Text", data_nv.DataSource, "MATP");
            txt_dd.DataBindings.Add("Text", data_nv.DataSource, "DIADIEM");
            date_ngaync.DataBindings.Add("Text", data_nv.DataSource, "NGAYNC");
        }

        private void txt_tim_ncc_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=QUANLYNHANSU;Integrated Security=True");
            con.Open();
            string timkiem = "select * from PHONGBAN where MAPB LIKE '%" + txt_tim_ncc.Text + "%'";
            SqlCommand com_tim = new SqlCommand(timkiem, con);
            SqlDataAdapter data = new SqlDataAdapter(com_tim);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            data_nv.DataSource = table;
        }
    }
}
