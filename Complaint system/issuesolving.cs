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
    public partial class issuesolving : Form
    {
        public issuesolving()
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

        private void issuesolving_FormClosing(object sender, FormClosingEventArgs e)
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

        private void issuesolving_Load(object sender, EventArgs e)
        {
            show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                con.Open();
                string comid = "";
                string nam = "";
                string cont = "";
                string cn = "";
                string ci = "";
                string ar = "";
                string body = "";

                string query = "select * from comp where complaint_id = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    comid = reader[0].ToString();
                    nam = reader[1].ToString();
                    cont = reader[2].ToString();
                    cn = reader[3].ToString();
                    ci = reader[4].ToString();
                    ar = reader[5].ToString();
                    body = reader[6].ToString();
                    check = true;

                }
                con.Close();

                if (check == true)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("Insert into solve(complaint_id,name,contact,cnic,city,area,complaint) values ('" + comid + "','" + nam + "','" + cont + "','" + cn + "','" + ci + "','" + ar + "','" + body + "')", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("delete from comp where complaint_id='" + comid + "'", con);
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    show();

                    string catt = "";

                    con.Open();
                    string query9 = "select * from graph where pin= '" + comid + "'";
                    SqlCommand cmd9 = new SqlCommand(query9, con);
                    SqlDataReader reader9 = cmd9.ExecuteReader();
                    if (reader9.Read())
                    {
                        catt = reader9[0].ToString();

                    }
                    con.Close();




                    con.Open();
                    SqlCommand cmd3 = new SqlCommand("Insert into solvegraph(solvecat,pin) values ('" + catt + "','" + comid + "')", con);
                    cmd3.ExecuteNonQuery();
                    con.Close();

                    textBox1.Clear();
                    MessageBox.Show("Sucess");
                }
                else
                {
                    MessageBox.Show("Wrong pin");
                }

            }
            catch
            {
                MessageBox.Show("Incorrect pin");
            }




            

        }
    }
}
