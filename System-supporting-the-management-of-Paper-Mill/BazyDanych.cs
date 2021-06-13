using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace System_supporting_the_management_of_Paper_Mill
{
    public partial class BazyDanych : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KC3GCMU; Initial Catalog=Paper Mill;Persist Security Info=True; User ID=administrator; Password=mateusz");
        public BazyDanych()
        {
            InitializeComponent();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from baza1", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into baza1 (id, nazwa_dokumentu, numer_dokumentu, rok_wydania, nowelizacja) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                cmd.ExecuteNonQuery();
                string msg = string.Format("Jest dobrze");
                MessageBox.Show(msg, "Dopisano rekord", MessageBoxButtons.OK);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Podstrona w trakcie przygotowania");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Podstrona w trakcie przygotowania");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Podstrona w trakcie przygotowania");
        }

        private void panelGłównyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Panel_główny().ShowDialog();
        }
    }
 }

