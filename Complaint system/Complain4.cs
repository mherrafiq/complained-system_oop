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
    public partial class Complain4 : Form
    {
        public Complain4()
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
                complaint += "dirty quality of water cause different infections\n";
            }
            if (checkBox2.Checked == true)
            {
                complaint += "Corruption in water sewerage board\n";
            }
            if (checkBox3.Checked == true)
            {
                complaint += "Taking bribe from citizens to solve their problem\n";
            }
            if (checkBox4.Checked == true)
            {
                complaint += "Rude behavious of staff\n";
            }
            if (checkBox5.Checked == true)
            {
                complaint += "Leakage of pipelines\n";
            }
            if (richTextBox1.Text != "")
            {
                complaint += richTextBox1.Text;
            }


            datahold.getdb(CNIC, city, area, complaint);
            datahold.gr("water");

            complaint += "Complaint id    : " + datahold.num + "\n";
            complaint += "\n\n\n\n\nCopyright all right reserved Pakistan complaint system 2019";

            datahold.SendSimpleMessage(complaint);
            MessageBox.Show("Success");

        }

        private void Complain4_Load(object sender, EventArgs e)
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

        private void Complain4_FormClosing(object sender, FormClosingEventArgs e)
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

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            usermain um = new usermain();
            um.Show();
        }
    }
}
