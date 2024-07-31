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
    interface random
    {
        bool hanlding();
    }
    public partial class register : Form,random
    {
        public register()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(myconnection.path());
        public bool hanlding()
        {
            if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Re enter password is not correct");
                return false;
            }
            else
            {
                
                if (textBox1.Text=="" || textBox3.Text=="" || textBox4.Text=="" || textBox5.Text=="" || maskedTextBox1.Text=="" )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            userlogin ul = new userlogin();
            ul.Show();
        }

        private void register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int num = r.Next(9999999, 1000000000);
            textBox5.Text = Convert.ToString(num);
            textBox4.Text = Convert.ToString(num);
            label7.Text = Convert.ToString(num);
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bool veri = hanlding();
            try
            {
                if (veri == false)
                {
                    MessageBox.Show("All fields are correct required");
                }
                else
                {
                    string valhold = textBox1.Text;

                    if (valhold.Length > 2)
                    {
                        if (textBox3.Text.Length > 2)
                        {
                            datahold.name = textBox1.Text;
                            datahold.contact = maskedTextBox1.Text;


                            con.Open();
                            SqlCommand cmd = new SqlCommand("Insert into users(name,password,contact,country) values ('" + textBox1.Text + "','" + textBox4.Text + "','" + maskedTextBox1.Text + "','" + textBox3.Text + "')", con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            this.Hide();
                            usermain um = new usermain();
                            um.Show();
                        }
                        else
                        {
                            MessageBox.Show("City length must be greator then 2");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name length must be greator then 2");
                    }
                }
                


            }
            catch
            {
                MessageBox.Show("Enter correct information");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
            }
        }
    }
}
