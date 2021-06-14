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
    public partial class Panel_główny : Form
    {
        public Panel_główny()
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
            MessageBox.Show("Panel w przygotowaniu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Panel w przygotowaniu");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BazyDanych baz = new BazyDanych();
            baz.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kalkulacje kal = new Kalkulacje();
            kal.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Panel w przygotowaniu");
        }
        #region odczytanie wartosci parametru i przypisanie wartosci do label6
        public string _textBox
        {
            set { label6.Text = value; }
        }
        #endregion
    }
}
