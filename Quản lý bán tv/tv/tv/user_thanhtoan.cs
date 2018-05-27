using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tv
{
    public partial class user_thanhtoan : UserControl
    {
        public user_thanhtoan()
        {
            InitializeComponent();
        }

        private void u1_Load(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void but_thanhtoan_Click(object sender, EventArgs e)
        {

        }
    }
}
