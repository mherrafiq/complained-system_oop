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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(myconnection.path());
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            usermain um = new usermain();
            um.Show();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            textBox1.Text=datahold.contact;
            textBox2.Text = datahold.name;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("All fields are required");
                }
                else
                {
                    if (textBox3.Text == textBox4.Text)
                    {
                        con.Open();
                        SqlCommand cnd = new SqlCommand("UPDATE users SET password='" + textBox3.Text + "' WHERE contact='" + datahold.contact + "'", con);
                        cnd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Operation Sucess");
                    }
                    else
                    {
                        MessageBox.Show("Password not same");
                    }
                }
            }
            catch
            {
                MessageBox.Show("All fields are correct required");
            }


        }
    }
}
