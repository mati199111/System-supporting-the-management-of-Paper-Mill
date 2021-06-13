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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main c = new Main();
            c.Show();
            this.Hide();

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("strona w przygotowaniu");
        }

        private void informacjeOProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = string.Format("Copyright by Mateusz Raczyński 2021");
            MessageBox.Show(info, "Informacja o programie", MessageBoxButtons.OK);
        }
    }
}
