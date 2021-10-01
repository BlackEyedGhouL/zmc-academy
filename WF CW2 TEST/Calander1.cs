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
    public partial class Calander1 : UserControl
    {
        public Calander1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DateTime time = DateTime.Now;
                string format = "yyyy-MM-dd HH:mm:ss";

                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZMC_Academy;User ID=admin;Password=admin";

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                string sql = "INSERT INTO Report_problem(Summary,Details,date,Id) VALUES('" + txtsummary.Text + "','" + txtdetails.Text + "','" + time.ToString(format) + "','" + Signin1.signinID + "' )";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Sumbitted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void txtsummary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtsummary.Text))
            {
                e.Cancel = true;
                txtsummary.Focus();
                errorProvider1.SetError(txtsummary, "Please Enter Your Problem Summary");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtsummary, null);
            }
        }

        private void txtdetails_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtdetails.Text))
            {
                e.Cancel = true;
                txtdetails.Focus();
                errorProvider1.SetError(txtdetails, "Please Enter Your Problem Details");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtdetails, null);
            }
        }
    }
}
