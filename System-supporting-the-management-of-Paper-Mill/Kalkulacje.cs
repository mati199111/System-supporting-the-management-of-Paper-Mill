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
    public partial class Kalkulacje : Form
    {
        public Kalkulacje()
        {
            InitializeComponent();
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }

        private void ekranLogowaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().ShowDialog();
            
        }

        private void ekranGłównyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
           
        }

        private void panelGłównyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Panel_główny().ShowDialog();
            
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dlugosc = textBox1.Text;
            float dlugosc2 = float.Parse(dlugosc);
            string szerokosc = textBox2.Text;
            float szerokosc2 = float.Parse(szerokosc);
            string gramatura = textBox3.Text;
            float gramatura2 = float.Parse(gramatura);
            string ark = textBox4.Text;
            float ark2 = float.Parse(ark);

            float wynik = ((dlugosc2 / 1000) * (szerokosc2 / 1000) * gramatura2 * ark2) / 1000;
            string wynik2 = wynik.ToString();
            textBox5.Text = wynik2;
        }
    }
}
