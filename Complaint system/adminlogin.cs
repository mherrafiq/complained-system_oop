using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complaint_system
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool check()
        {
            if (textBox1.Text=="" || textBox2.Text=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool security()
        {
            bool hold = check();

            if (hold == false)
            {
                MessageBox.Show("Please enter username and password");
                return false;
            }
            else
            {
                if (textBox1.Text == "admin" && textBox2.Text == "1234")
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void adminlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            usermain um = new usermain();
            um.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool verify = security();

                if (verify == true)
                {
                    this.Hide();
                    adminmain am = new adminmain();
                    am.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
            catch
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
