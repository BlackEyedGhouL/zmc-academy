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
    public partial class Attendence1 : UserControl
    {
        public Attendence1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS; Initial Catalog = ZMC_Academy; User ID = admin; Password = admin";

                cnn = new SqlConnection(connectionString);

                cnn.Open();
                String sql = "Select * from Attendence1 where Id = '" + Signin1.signinID+ "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                cnn.Close();
            }
            else
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS; Initial Catalog = ZMC_Academy; User ID = admin; Password = admin";

                cnn = new SqlConnection(connectionString);

                cnn.Open();
                String sql = "Select * from Attendence2 where Id = '" + Signin1.signinID + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                cnn.Close();
            }
        }
    }
}
