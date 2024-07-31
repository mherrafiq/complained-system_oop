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
    public partial class userlogin : Form
    {
        public userlogin()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(myconnection.path());

        public void dataset()
        {
            con.Open();

            string query = "select * from users where name = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datahold.name = reader[0].ToString();
                datahold.contact = reader[2].ToString();
            }

            con.Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register re = new register();
            re.Show();
        }
        public void userhandling()
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from users where name='" + user + "'and password='" + pass + "'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                usermain um = new usermain();
                um.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void userlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                dataset();
                userhandling();
            }
            catch
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void userlogin_Load(object sender, EventArgs e)
        {
            

        }
    }
}
