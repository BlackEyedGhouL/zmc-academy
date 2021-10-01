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
using System.Net;
using System.Net.Mail;

namespace WF_CW2_TEST
{
    public partial class Resetpass1 : Form
    {
        public Resetpass1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin1 signin1 = new Signin1();
            signin1.Show();
        }

        public static string resetemail;
        public static string randomcode1;

        private void Resetpass1_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZMC_Academy;User ID=admin;Password=admin";

                cnn = new SqlConnection(connectionString);
                cnn.Open();
                string sql = "Select Email from Registration where Id = '" + Signin1.SigninForget + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    resetemail = "" + reader.GetValue(0).ToString();
                }
                cnn.Close();

                Random random = new Random();
                randomcode1 = (random.Next(999999)).ToString();

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("senithumeshac@gmail.com");
                mail.To.Add(resetemail);
                mail.Subject = "Password reset code";
                mail.Body = "Here is your code : " + randomcode1;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("senithumeshac@gmail.com", "senithumeshac#");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);            
            }
            catch (Exception)
            {
                if (MessageBox.Show("Please check your internet connection", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                    Signin1 signin1 = new Signin1();
                    signin1.Show();
                }
            }
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (randomcode1 == txtcode.Text)
            {
                this.Hide();
                Resetpass2 resetpass2 = new Resetpass2();
                resetpass2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Enter the Valid Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
