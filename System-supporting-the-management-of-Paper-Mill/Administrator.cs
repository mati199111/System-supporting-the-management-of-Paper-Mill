using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace System_supporting_the_management_of_Paper_Mill
{
    public partial class Administrator : Form
    {
        
        public Administrator()
        {
            InitializeComponent();
        }

        private void ekranGłównyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void ekranLogowaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().ShowDialog();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adm_display a = new Adm_display();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adm_add ad = new Adm_add();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adm_errors er = new Adm_errors();
            er.Show();
        }
    }
}
