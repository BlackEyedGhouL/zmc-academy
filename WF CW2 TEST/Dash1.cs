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

namespace WF_CW2_TEST
{
    public partial class Dash1 : Form
    {
        public Dash1()
        {
            InitializeComponent();

            lbltime.Text = DateTime.Now.ToLongTimeString();

            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZMC_Academy;User ID=admin;Password=admin";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "Select Name from Registration where Id = '" + Signin1.signinID + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtnameshow.Text = "Welcome , " + reader.GetValue(0).ToString();
            }
            cnn.Close();          
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dash1_Load(object sender, EventArgs e)
        {
            panel7.Height = button1.Height;
            panel7.Top = button1.Top;
            calander11.Hide();
            library11.Hide();
            attendence11.Hide();
            pastpapers11.Hide();
            courses11.Hide();
            news11.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            library11.Hide();
            pastpapers11.Hide();
            attendence11.Hide();
            courses11.Hide();
            news11.Hide();
            calander11.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calander11.Hide();
            library11.Hide();
            attendence11.Hide();
            pastpapers11.Hide();
            courses11.Hide();
            news11.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel7.Height = button6.Height;
            panel7.Top = button6.Top;
            calander11.Hide();
            attendence11.Hide();
            pastpapers11.Hide();
            news11.Hide();
            courses11.Hide();
            library11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel7.Height = button1.Height;
            panel7.Top = button1.Top;
            calander11.Hide();
            library11.Hide();
            courses11.Hide();
            attendence11.Hide();
            pastpapers11.Hide();
            news11.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel7.Height = button7.Height;
            panel7.Top = button7.Top;
            calander11.Hide();
            library11.Hide();
            news11.Hide();
            courses11.Hide();
            attendence11.Hide();
            pastpapers11.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel7.Height = button8.Height;
            panel7.Top = button8.Top;
            calander11.Hide();
            library11.Hide();
            courses11.Hide();
            news11.Hide();
            pastpapers11.Hide();
            attendence11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel7.Height = button2.Height;
            panel7.Top = button2.Top;

            if (MessageBox.Show("Do you want to sign out ?", "User Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                home home1 = new home();
                home1.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel7.Height = button9.Height;
            panel7.Top = button9.Top;
            calander11.Hide();
            library11.Hide();
            news11.Hide();
            pastpapers11.Hide();
            attendence11.Hide();
            courses11.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void courses11_Load(object sender, EventArgs e)
        {

        }
    }
}
