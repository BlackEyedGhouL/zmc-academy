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
    public partial class Signup1 : Form
    {
        public static string name;
        public static string id;
        public static string address;
        public static string password;
        public static string phonenum;
        public static string email;
        public static string dob;

        public Signup1()
        {
            InitializeComponent();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaboutus_Click(object sender, EventArgs e)
        {
            this.Close();
            home home1 = new home();
            home1.Show();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                name = txtname.Text;
                id = txtid.Text;
                address = txtaddress.Text;
                password = txtpass.Text;
                phonenum = txtcn.Text;
                email = txtemail.Text;
                dob = dateTimePicker1.Value.ToString();

                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZMC_Academy;User ID=admin;Password=admin";
          
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    string sql1 = "Select Id from Registration where Id = '" + id + "'";
                    SqlCommand cmd1 = new SqlCommand(sql1, cnn);
                    SqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.HasRows)
                    {
                        MessageBox.Show("This ID has already been registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        string sql2 = "Select Email from Registration where Email = '" + email + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                        SqlDataReader reader2 = cmd2.ExecuteReader();

                        if (reader2.HasRows)
                        {
                            MessageBox.Show("This email has already been registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Hide();
                            Signup2 signup2 = new Signup2();
                            signup2.ShowDialog();
                        }
                        cnn.Close();
                    }
                    cnn.Close();
            }
        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                e.Cancel = true;
                txtname.Focus();
                errorProvider1.SetError(txtname, "Please Enter Your Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtname, null);
            }
        }

        private void txtid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                e.Cancel = true;
                txtid.Focus();
                errorProvider1.SetError(txtid, "Please Enter Your ID");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtid, null);
            }
        }

        private void txtaddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtaddress.Text))
            {
                e.Cancel = true;
                txtaddress.Focus();
                errorProvider1.SetError(txtaddress, "Please Enter Your Address");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtaddress, null);
            }
        }

        private void txtcn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcn.Text))
            {
                e.Cancel = true;
                txtcn.Focus();
                errorProvider1.SetError(txtcn, "Please Enter Your Contact Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtcn, null);
            }
        }

        private void txtschool_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtemail.Text))
            {
                e.Cancel = true;
                txtemail.Focus();
                errorProvider1.SetError(txtemail, "Please Enter Your Email");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtemail, null);
            }
        }

        private void txtpass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                e.Cancel = true;
                txtpass.Focus();
                errorProvider1.SetError(txtpass, "Please Enter Your Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtpass, null);
            }
        }

        private void txtcn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 && chr !='+')
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Signup1_Load(object sender, EventArgs e)
        {

        }
    }
}
