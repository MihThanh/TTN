using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void đĂNGNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.MdiParent = this;
            fr.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NV fr = new NV();
            fr.MdiParent = this;
            fr.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KH fr = new KH();
            fr.MdiParent = this;
            fr.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMNCC fr = new DMNCC();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SP fr = new SP();
            fr.MdiParent = this;
            fr.Show();
        }

        private void hóaĐơnNhậToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDN fr = new HDN();
            fr.MdiParent = this;
            fr.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDB fr = new HDB();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TKHH fr = new TKHH();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
