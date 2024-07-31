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


namespace Complaint_system
{
    public partial class solvedcomp : Form
    {
        public solvedcomp()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(myconnection.path());

        public void show()
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from solve", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void solvedcomp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminmain am = new adminmain();
            am.Show();
        }

        private void solvedcomp_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
