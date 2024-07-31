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
    public partial class Complain5 : Form
    {
        public Complain5()
        {
            InitializeComponent();
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
            complaint += "CNIC         : " + CNIC + "\n";
            complaint += "City         : " + city + "\n";
            complaint += "Area         : " + area + "\n";

            complaint += "Conplaint    \n\n";

            if (checkBox1.Checked == true)
            {
                complaint += "Sui gas leakage from main supply line\n";
            }
            if (checkBox2.Checked == true)
            {
                complaint += "Taking bribes from citizen to solve their problems\n";
            }
            if (checkBox3.Checked == true)
            {
                complaint += "Rude behaviour of customer service staff\n";
            }
            if (checkBox4.Checked == true)
            {
                complaint += "Late response after complain\n";
            }
            if (checkBox5.Checked == true)
            {
                complaint += "Problem facing during submission of online bill\n";
            }
            if (richTextBox1.Text != "")
            {
                complaint += richTextBox1.Text;
            }


            datahold.getdb(CNIC, city, area, complaint);
            datahold.gr("ssgc");

            complaint += "Complaint id    : " + datahold.num + "\n";
            complaint += "\n\n\n\n\nCopyright all right reserved Pakistan complaint system 2019";

            datahold.SendSimpleMessage(complaint);
            MessageBox.Show("Success");

        }

        private void Complain5_Load(object sender, EventArgs e)
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
            if (comboBox1.SelectedItem.ToString() == "Karachi")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("DHA");
                comboBox2.Items.Add("Malir");
                comboBox2.Items.Add("New karachi");
                comboBox2.Items.Add("Cantt");
            }
            else if (comboBox1.SelectedItem.ToString() == "Lahore")
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

        private void Complain5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
