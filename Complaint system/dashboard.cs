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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(myconnection.path());

        private void dashboard_Load(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlDataAdapter sadp222 = new SqlDataAdapter("select * from solve", con);
                DataTable dt111 = new DataTable();
                sadp222.Fill(dt111);
                if (dt111 != null)
                {
                    label1.Text = dt111.Rows.Count.ToString();

                }
                else
                {
                    MessageBox.Show("Invalid pin ");
                }
                con.Close();





                con.Open();

                SqlDataAdapter sadp20 = new SqlDataAdapter("select * from users", con);
                DataTable dt10 = new DataTable();
                sadp20.Fill(dt10);
                if (dt10 != null)
                {
                    label6.Text = dt10.Rows.Count.ToString();

                }
                else
                {
                    MessageBox.Show("Invalid pin ");
                }
                con.Close();



                label5.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                label4.Text = DateTime.Now.ToString("HH:mm");

                int[] rank = new int[5];

                con.Open();

                SqlDataAdapter sadp1 = new SqlDataAdapter("select * from graph", con);
                DataTable dt90 = new DataTable();
                sadp1.Fill(dt90);

                for (int i = 0; i < dt90.Rows.Count; i++)
                {
                    string d1 = dt90.Rows[i]["dept"].ToString();

                    if (d1 == "police")
                    {
                        rank[0]++;
                    }
                    else if (d1 == "ssgc")
                    {
                        rank[1]++;
                    }
                    else if (d1 == "mpa")
                    {
                        rank[2]++;
                    }
                    else if (d1 == "water")
                    {
                        rank[3]++;
                    }
                    else if (d1 == "sewerage")
                    {
                        rank[4]++;
                    }
                }
                con.Close();
                this.chart1.Series["category"].Points.AddXY("police", rank[0]);
                this.chart1.Series["category"].Points.AddXY("ssgc", rank[1]);
                this.chart1.Series["category"].Points.AddXY("MPA", rank[2]);
                this.chart1.Series["category"].Points.AddXY("water", rank[3]);
                this.chart1.Series["category"].Points.AddXY("Sewerage", rank[4]);


                int[] rank1 = new int[5];

                con.Open();

                SqlDataAdapter sadp19 = new SqlDataAdapter("select * from solvegraph", con);
                DataTable dt909 = new DataTable();
                sadp19.Fill(dt909);

                for (int i = 0; i < dt909.Rows.Count; i++)
                {
                    string d19 = dt909.Rows[i]["solvecat"].ToString();

                    if (d19 == "police")
                    {
                        rank1[0]++;
                    }
                    else if (d19 == "ssgc")
                    {
                        rank1[1]++;
                    }
                    else if (d19 == "mpa")
                    {
                        rank1[2]++;
                    }
                    else if (d19 == "water")
                    {
                        rank1[3]++;
                    }
                    else if (d19 == "sewerage")
                    {
                        rank1[4]++;
                    }
                }
                con.Close();


                this.chart2.Series["category"].Points.AddXY("police", rank1[0]);
                this.chart2.Series["category"].Points.AddXY("ssgc", rank1[1]);
                this.chart2.Series["category"].Points.AddXY("MPA", rank1[2]);
                this.chart2.Series["category"].Points.AddXY("water", rank1[3]);
                this.chart2.Series["category"].Points.AddXY("Sewerage", rank1[4]);


                con.Open();

                SqlDataAdapter sadp = new SqlDataAdapter("select * from graph", con);
                DataTable dt = new DataTable();
                sadp.Fill(dt);
                if (dt != null)
                {
                    label9.Text = dt.Rows.Count.ToString();

                }
                else
                {
                    MessageBox.Show("Invalid pin ");
                }
                con.Close();



                


                con.Open();

                SqlDataAdapter sadp4 = new SqlDataAdapter("select * from comp", con);
                DataTable dt2 = new DataTable();
                sadp4.Fill(dt2);
                if (dt2 != null)
                {
                    label10.Text = dt2.Rows.Count.ToString();

                }
                else
                {
                    MessageBox.Show("Invalid pin ");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminmain ad = new adminmain();
            ad.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
