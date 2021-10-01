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
    public partial class Resetpass2 : Form
    {
        public Resetpass2()
        {
            InitializeComponent();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnewpass.Text == txtconfirmnewpass.Text)
                {
                    string connectionString;
                    SqlConnection cnn;

                    connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZMC_Academy;User ID=admin;Password=admin";

                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sql = "";
                    sql = "Update Registration SET Password = '" + txtconfirmnewpass.Text + "' where Id = " + Signin1.SigninForget + "";
                    command = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();

                    if(MessageBox.Show("Password Reset Successfully", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)== DialogResult.OK)
                    {
                        this.Hide();
                        Signin1 signin1 = new Signin1();
                        signin1.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords Doesn't Match", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
