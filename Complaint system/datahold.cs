using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;
using System.IO;

namespace Complaint_system
{
    public static class datahold
    {
        public static string name = "";
        public static string contact = "";
        public static int num = 0;

        

        public static void getdb(string cn, string ci, string ar, string co)
        {
            Random ra = new Random();
            num = ra.Next(99999, 9999999);

            SqlConnection con = new SqlConnection(myconnection.path());
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into comp(complaint_id,name,contact,cnic,city,area,complaint) values ('" + num + "','" + name + "','" + contact + "','" + cn + "','" + ci + "','" + ar + "','" + co + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void gr(string cat)
        {
            SqlConnection con = new SqlConnection(myconnection.path());
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into graph(dept,pin) values ('"+cat+"','"+num+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static IRestResponse SendSimpleMessage(string body)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator = new HttpBasicAuthenticator("api", "501a3b9e23fff5b833873741759339a2-09001d55-add58f96");
            RestRequest request = new RestRequest();
            request.AddParameter("domain", "sandbox865b0265cfaf4fe6a474df684cc1a493.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";

            request.AddParameter("from", "Complaint System <info-email@Compaint-system.com.pk>");
            request.AddParameter("to", "Madiha khan <madikhan2310@gmail.com>");
            request.AddParameter("subject", "New Complaint");
            request.AddParameter("text", body);
            request.Method = Method.POST;
            return client.Execute(request);
        }

    }
}
