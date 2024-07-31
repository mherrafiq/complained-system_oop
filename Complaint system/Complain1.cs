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
    public partial class Complain1 : Form
    {
        public Complain1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(myconnection.path());

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        public bool check()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || maskedTextBox1.Text == "" || comboBox1.SelectedItem.ToString() == "" || comboBox2.SelectedItem.ToString() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void getdata()
        {
            
            string CNIC = maskedTextBox1.Text;
            string city = comboBox1.SelectedItem.ToString();
            string area = comboBox2.SelectedItem.ToString();
            string complaint = "";

            complaint += "Name         : " + datahold.name + "\n";
            complaint += "Contact      : " + datahold.contact + "\n";
            complaint += "CNIC         : " + CNIC+ "\n";
            complaint += "City         : " + city + "\n";
            complaint += "Area         : " + area + "\n";

            complaint += "Conplaint    \n\n";

            if (checkBox1.Checked==true)
            {
                complaint += "Rude behaviour of police donot listen to issues.\n";
            }
            if (checkBox2.Checked == true)
            {
                complaint += "Taking bribes and release criminals.\n";
            }
            if (checkBox3.Checked == true)
            {
                complaint += "Charge illegal fee for FIR.\n";
            }
            if (checkBox4.Checked == true)
            {
                complaint += "Work under pressure of politician\n";
            }
            if (checkBox5.Checked == true)
            {
                complaint += "Not interested in solving causes\n";
            }
            if (richTextBox1.Text!="")
            {
                complaint += richTextBox1.Text;
            }
           

            datahold.getdb(CNIC, city, area, complaint);
            datahold.gr("police");
            complaint += "Complaint id    : " + datahold.num + "\n";
            complaint += "\n\n\n\n\nCopyright all right reserved Pakistan complaint system 2019";

            datahold.SendSimpleMessage(complaint);
            MessageBox.Show("Success");
             
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Complain1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Karachi");
            comboBox1.Items.Add("Lahore");
            comboBox1.Items.Add("Peshawer");
            comboBox1.Items.Add("Quetta");

            textBox1.Text = datahold.name;
            textBox2.Text = datahold.contact;

            textBox1.Enabled = false;
            textBox2.Enabled = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString()=="Karachi")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("DHA");
                comboBox2.Items.Add("Malir");
                comboBox2.Items.Add("New karachi");
                comboBox2.Items.Add("Cantt");
            }
            else if (comboBox1.SelectedItem.ToString()=="Lahore")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Model town");
                comboBox2.Items.Add("Cannal road");
                comboBox2.Items.Add("Izmir Town");
                comboBox2.Items.Add("Green Town");
            }
            else if (comboBox1.SelectedItem.ToString() == "Peshawer")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bahadur Kalay");
                comboBox2.Items.Add("Hayatabad");
                comboBox2.Items.Add("Badaber");
                comboBox2.Items.Add("Jamrud");
            }
            else if (comboBox1.SelectedItem.ToString() == "Quetta")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ziarat");
                comboBox2.Items.Add("Central city");

            }
        }

        private void Complain1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool veri = check();

                if (veri == true)
                {
                    getdata();

                }
                else
                {
                    MessageBox.Show("All fields are required");
                }
            }
            catch
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            usermain um = new usermain();
            um.Show();
        }
    }
}
