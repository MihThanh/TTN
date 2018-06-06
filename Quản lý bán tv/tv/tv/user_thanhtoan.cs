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
    public partial class user_thanhtoan : UserControl
    {
        public user_thanhtoan()
        {
            InitializeComponent();
            loadcb1();
            loadcb2();
            loadcb3();
            //tongtien();

        }

        private void u1_Load(object sender, EventArgs e)
        {

        }

        private static user_thanhtoan _instance;
        public static user_thanhtoan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user_thanhtoan();
                return _instance;
            }
        }
        public void loadcb2()
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            string sql = "select MANV,HOTEN from NHANVIEN";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            data.Fill(ds, "NHANVIEN");
            com_manv.DataSource = ds.Tables[0];
            com_manv.ValueMember = "MANV";
            com_manv.DisplayMember = "HOTEN";
        }
        public void loadcb1()
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            string sql = "select MANCC,TENNCC from NHACC";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            data.Fill(ds, "NHACC");
            com_hang.DataSource = ds.Tables[0];
            com_hang.ValueMember = "MANCC";
            com_hang.DisplayMember = "TENNCC";
        }
        public void loadcb3()
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            string sql = "select MAKH,TENKH from KHACHHANG";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            data.Fill(ds, "KHACHHANG");
            com_kh.DataSource = ds.Tables[0];
            com_kh.ValueMember = "MAKH";
            com_kh.DisplayMember = "TENKH";
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Add(1);
            int indexRow = dataGridView1.Rows.Count - 1;
            dataGridView1[0, indexRow].Value = txt_mahdb.Text;
            dataGridView1[1, indexRow].Value = com_hang.Text;
            dataGridView1[2, indexRow].Value = com_loai.Text;
            dataGridView1[3, indexRow].Value = com_kh.Text;
            dataGridView1[4, indexRow].Value = com_manv.Text;
            dataGridView1[5, indexRow].Value = date_ngayxuat.Text;
            dataGridView1[6, indexRow].Value = num_soluong.Text;
            int dongia = Convert.ToInt32(com_gia.Text);
            int soluong = Convert.ToInt32(num_soluong.Text);
            int tong = dongia * soluong;
            dataGridView1[7, indexRow].Value = tong.ToString();

        }
        

        private void com_hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
            con.Open();
            string sql = "select TENSP, MASP from SANPHAM where MANCC ='" + com_hang.SelectedValue.ToString().Trim() + "'";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            data.Fill(ds);
            com_loai.DataSource = ds.Tables[0];
            com_loai.ValueMember = "MASP";
            com_loai.DisplayMember = "TENSP";
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(RowIndex);
        }
        private void but_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("Hóa đơn đã được thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                    con.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        string sql = "insert into HOADONBAN(MAHDBAN, MANV, NGAYXUAT, MASP, SOLUONG, GTBAN, MAKH) values('" + dataGridView1.Rows[i].Cells["mahdb"].Value + "', '" + com_manv.SelectedValue.ToString().Trim() + "', '" + dataGridView1.Rows[i].Cells["ngayxuat"].Value + "', '" + com_loai.SelectedValue.ToString().Trim() + "', '" + dataGridView1.Rows[i].Cells["soluong"].Value + "', '" + dataGridView1.Rows[i].Cells["thanhtien"].Value + "', '" + com_kh.SelectedValue.ToString().Trim() + "')";
                        SqlCommand com = new SqlCommand(sql, con);
                        com.ExecuteNonQuery();
                    }
                    con.Close();
                    dataGridView1.Rows.Clear();
                    txt_mahdb.Clear();
                    
            }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void com_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_loai.Text == null)
            {
                com_gia.Text = "";
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BANTIVI;Integrated Security=True");
                con.Open();
                string sql = "select GIA from SANPHAM where MASP = '" + com_loai.SelectedValue.ToString().Trim() + "'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataAdapter data = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                data.Fill(ds, "SANPHAM");
                com_gia.DataSource = ds.Tables[0];
                com_gia.ValueMember = "GIA";
                com_gia.DisplayMember = "GIA";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void but_kh_Click(object sender, EventArgs e)
        {
            them_kh f1 = new them_kh();
            f1.Show();
        }


        /*private void button1_Click(object sender, EventArgs e)
        {
            int sc = dataGridView1.Rows.Count;
            float tongtien=0;
            for (int i = 0; i < sc - 1; i++)
            {
                tongtien += float.Parse(dataGridView1.Rows[i].Cells["thanhtien"].Value.ToString());
            }
            txt_tong.Text = tongtien.ToString();
        }*/


    }
}
