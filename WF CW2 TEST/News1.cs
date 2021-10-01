using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WF_CW2_TEST
{
    public partial class News1 : UserControl
    {
        public News1()
        {
            InitializeComponent();
        }

        private void News1_Load(object sender, EventArgs e)
        {
            string A = "A"; string B = "B"; string C = "C"; string D = "D";
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZMC_Academy;User ID=admin;Password=admin";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql1 = "Select News_name from News where News_id = '" + A + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, cnn);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                txtnews1.Text = reader1.GetValue(0).ToString();
            }
            cnn.Close();

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql2 = "Select News_name from News where News_id = '" + B + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, cnn);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.Read())
            {
                txtnews2.Text = reader2.GetValue(0).ToString();
            }
            cnn.Close();

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql3 = "Select News_name from News where News_id = '" + C + "'";
            SqlCommand cmd3 = new SqlCommand(sql3, cnn);
            SqlDataReader reader3 = cmd3.ExecuteReader();

            if (reader3.Read())
            {
                txtnews3.Text = reader3.GetValue(0).ToString();
            }
            cnn.Close();

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql4 = "Select News_name from News where News_id = '" + D + "'";
            SqlCommand cmd4 = new SqlCommand(sql4, cnn);
            SqlDataReader reader4 = cmd4.ExecuteReader();

            if (reader4.Read())
            {
                txtnews4.Text = reader4.GetValue(0).ToString();
            }
            cnn.Close();

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql5 = "Select News_date from News where News_id = '" + A + "'";
            SqlCommand cmd5 = new SqlCommand(sql5, cnn);
            SqlDataReader reader5 = cmd5.ExecuteReader();

            if (reader5.Read())
            {
                txtnewsdate1.Text = reader5.GetValue(0).ToString();
            }
            cnn.Close();

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql6 = "Select News_date from News where News_id = '" + B + "'";
            SqlCommand cmd6 = new SqlCommand(sql6, cnn);
            SqlDataReader reader6 = cmd6.ExecuteReader();

            if (reader6.Read())
            {
                txtnewsdate2.Text = reader6.GetValue(0).ToString();
            }
            cnn.Close();

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql7 = "Select News_date from News where News_id = '" + C + "'";
            SqlCommand cmd7 = new SqlCommand(sql7, cnn);
            SqlDataReader reader7 = cmd7.ExecuteReader();

            if (reader7.Read())
            {
                txtnewsdate3.Text = reader7.GetValue(0).ToString();
            }
            cnn.Close();

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql8 = "Select News_date from News where News_id = '" + D + "'";
            SqlCommand cmd8 = new SqlCommand(sql8, cnn);
            SqlDataReader reader8 = cmd8.ExecuteReader();

            if (reader8.Read())
            {
                txtnewsdate4.Text = reader8.GetValue(0).ToString();
            }
            cnn.Close();
        }
    }
}
