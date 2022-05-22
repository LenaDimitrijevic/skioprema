using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skioprema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void musterijeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("musterije");
            frm.Show();
        }

        private void skijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("skije");
            frm.Show();
        }

        private void stapoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("stapovi");
            frm.Show();
        }

        private void pancericeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("pancerice");
            frm.Show();
        }

        private void kacigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("kacige");
            frm.Show();
        }

        private void brendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("brend");
            frm.Show();
        }

        private void iznajmljenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("iznajmljivanje");
            frm.Show();
        }

        private void Form1FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
