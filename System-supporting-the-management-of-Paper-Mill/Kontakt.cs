using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace System_supporting_the_management_of_Paper_Mill
{
    public partial class Kontakt : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KC3GCMU; Initial Catalog=Paper Mill;Persist Security Info=True; User ID=administrator; Password=mateusz");
        public Kontakt()
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
            
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Kontakt (Id, Imie, Nazwisko, Login, Dział, Opis) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6 + "')";
                cmd.ExecuteNonQuery();
                string msg = string.Format("Wysłano");
                MessageBox.Show(msg, "Dopisano rekord", MessageBoxButtons.OK);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                string blad = string.Format("Problem podczas logowania", ex.Message);
                MessageBox.Show(blad, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream mystream;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "text files (*.txt)| *.txt| All files (*.*)| *.txt";
            save.FilterIndex = 2;
            save.RestoreDirectory = true;
            if(save.ShowDialog() == DialogResult.OK)
            {
                if ((mystream = save.OpenFile()) != null)
                {
                    byte[] data = Encoding.UTF8.GetBytes("Imię" + " " + textBox1.Text + "\n");
                    byte[] data2 = Encoding.UTF8.GetBytes("Nazwisko" + " " + textBox2.Text + "\n");
                    byte[] data3 = Encoding.UTF8.GetBytes("Login" + " " + textBox3.Text + "\n");
                    byte[] data4 = Encoding.UTF8.GetBytes("Dział" + " " + textBox4.Text + "\n");
                    byte[] data5 = Encoding.UTF8.GetBytes("Opis" + " " + textBox5.Text + "\n");

                    int i = 0;
                    mystream.Write(data, i, data.Length);
                    mystream.Write(data2, i, data2.Length);
                    mystream.Write(data3, i, data3.Length);
                    mystream.Write(data4, i, data4.Length);
                    mystream.Write(data5, i, data5.Length);
                }
            }
        }
    }
}
