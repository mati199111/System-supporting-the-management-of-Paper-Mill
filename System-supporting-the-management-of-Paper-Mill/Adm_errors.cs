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
    public partial class Adm_errors : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KC3GCMU; Initial Catalog=Paper Mill;Persist Security Info=True; User ID=administrator; Password=mateusz");
        public Adm_errors()
        {
            InitializeComponent();
        }

        private void panelAdmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Administrator().ShowDialog();
            
        }

        private void panelLogowaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().ShowDialog();
            
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Kontakt", conn);
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
    }
}
