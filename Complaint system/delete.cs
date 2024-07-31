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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(myconnection.path());

        public void show()
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from comp", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void delete_Load(object sender, EventArgs e)
        {
            show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand cmd = new SqlCommand("delete from comp where complaint_id='" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                show();
            }
            catch
            {
                MessageBox.Show("incorrect pin");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminmain am = new adminmain();
            am.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void delete_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
