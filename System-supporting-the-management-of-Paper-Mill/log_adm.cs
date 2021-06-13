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
    public partial class log_adm : Form
    {
        SqlConnection conn = null;
        public log_adm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-KC3GCMU; Initial Catalog=Paper Mill;Persist Security Info=True; User ID=administrator; Password=mateusz");
                conn.Open();
                string txtuser = textBox1.Text;
                string txtpasswd = textBox2.Text;
                string query = "select * from logins_adm where login=@user and password=@passwd";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtuser);
                cmd.Parameters.AddWithValue("@passwd", txtpasswd);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Logowanie udane");
                    this.Hide();
                    new Administrator().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Logowanie nieudane");
                }
            }
            catch (Exception ex)
            {
                string blad = string.Format("Wystąpił problem podczas logowania do systemu", ex.Message);
                MessageBox.Show(blad, "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
