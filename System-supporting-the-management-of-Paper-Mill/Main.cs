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
    public partial class Main : Form
    {
        
        SqlConnection conn = null;
        public Main()
        {
            InitializeComponent();
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("podstrona w trakcie realizacji");
            log_adm log = new log_adm();
            this.Hide();
            log.Show();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("W przypadku zapomnienia hasła, skontktuj się z administratorem poprzez zakładkę pomoc");
            Kontakt kon = new Kontakt();
            this.Hide();
            kon.Show();
        }

        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("W przypadku problemów z logowaniem, prosimy wysłać maila pod adres admin@gąbka.com");
        }
        #region sql connection
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-KC3GCMU; Initial Catalog=Paper Mill;Persist Security Info=True; User ID=administrator; Password=mateusz");
                conn.Open();
                string txtuser = textBox1.Text;
                string txtpasswd = textBox2.Text;
                string query = "select * from logins where login=@user and password=@passwd";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtuser);
                cmd.Parameters.AddWithValue("@passwd", txtpasswd);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows == true)
                {
                    MessageBox.Show("Logowanie udane");
                    this.Hide();
                    //new Panel_główny().ShowDialog();
                    Panel_główny pg = new Panel_główny();
                    pg._textBox = _textBox1; //przekazywanie parametru
                    pg.Show();

                }
                else
                {
                    MessageBox.Show("Logowanie nieudane");
                }
            }
            catch(Exception ex)
            {
                string blad = string.Format("Wystąpił problem podczas logowania do systemu", ex.Message);
                MessageBox.Show(blad, "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        #region przekazywanie parametru 
        public string _textBox1
        {
            get { return textBox1.Text; }
        }
        #endregion
        #endregion
        private void ekranGłównyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }
    }
}
