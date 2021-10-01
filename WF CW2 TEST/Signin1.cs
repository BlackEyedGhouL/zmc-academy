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
    public partial class Signin1 : Form
    {
        public static string signinID;

        public Signin1()
        {
            InitializeComponent();
        }

        private void txtsigninid_Enter(object sender, EventArgs e)
        {
            if (txtsigninid.Text.Equals("     ID"))
            {
                txtsigninid.Text = "";
            }
        }

        private void txtsigninid_Leave(object sender, EventArgs e)
        {
            if (txtsigninid.Text.Equals(""))
            {
                txtsigninid.Text = "     ID";
            }
        }

        private void txtsinginpassword_Enter(object sender, EventArgs e)
        {
            if (txtsinginpassword.Text.Equals("     Password"))
            {
                txtsinginpassword.Text = "";
            }
        }

        private void txtsinginpassword_Leave(object sender, EventArgs e)
        {
            if (txtsinginpassword.Text.Equals(""))
            {
                txtsinginpassword.Text = "     Password";
            }
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            home home1 = new home();
            home1.Show();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZMC_Academy;User ID=admin;Password=admin";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "Select * from Registration where Id = '" + txtsigninid.Text + "' and Password = '" + txtsinginpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (MessageBox.Show("Login Successfully", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    signinID = txtsigninid.Text;

                    this.Hide();
                    Dash1 dash1 = new Dash1();
                    dash1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Either your id or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cnn.Close();

        }

        public static string SigninForget;

        private void btnforget_Click(object sender, EventArgs e)
        {
            if (txtsigninid.Text == "     ID")
            {
                MessageBox.Show("Please Enter Your ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZMC_Academy;User ID=admin;Password=admin";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
                string sql = "Select * from Registration where Id = '" + txtsigninid.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (MessageBox.Show("Your verification code has been sent", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        SigninForget = txtsigninid.Text;

                        this.Hide();
                        Resetpass1 resetpass1 = new Resetpass1();
                        resetpass1.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter A Valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cnn.Close();   
            }           
        }
    }
}
