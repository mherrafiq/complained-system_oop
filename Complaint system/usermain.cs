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
    public partial class usermain : Form
    {
        public usermain()
        {
            InitializeComponent();
        }

        private void usermain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.LightGreen;
            button3.BackColor = Color.LightGreen;
            button4.BackColor = Color.LightGreen;
            button5.BackColor = Color.LightGreen;
            this.Hide();
            Complain1 c1 = new Complain1();
            c1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
            button2.BackColor = Color.White;
            button3.BackColor = Color.LightGreen;
            button4.BackColor = Color.LightGreen;
            button5.BackColor = Color.LightGreen;
            this.Hide();
            Complain5 c5 = new Complain5();
            c5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
            button2.BackColor = Color.LightGreen;
            button3.BackColor = Color.White;
            button4.BackColor = Color.LightGreen;
            button5.BackColor = Color.LightGreen;
            this.Hide();
            Complain4 c4 = new Complain4();
            c4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
            button2.BackColor = Color.LightGreen;
            button3.BackColor = Color.LightGreen;
            button4.BackColor = Color.White;
            button5.BackColor = Color.LightGreen;
            this.Hide();
            Complain2 c2 = new Complain2();
            c2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
            button2.BackColor = Color.LightGreen;
            button3.BackColor = Color.LightGreen;
            button4.BackColor = Color.LightGreen;
            button5.BackColor = Color.White;
            this.Hide();
            Complain3 c3 = new Complain3();
            c3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            userlogin ul = new userlogin();
            ul.Show();
        }

        private void usermain_Load(object sender, EventArgs e)
        {
            label3.Text = datahold.name;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            setting s = new setting();
            s.Show();
        }
    }
}
