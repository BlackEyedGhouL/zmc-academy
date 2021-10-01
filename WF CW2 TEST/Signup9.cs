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
    public partial class Signup9 : Form
    {
        public static string randomcode2;

        public Signup9()
        {
            InitializeComponent();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup7 signup7 = new Signup7();
            signup7.Show();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (randomcode2 == txtverificode.Text)
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZMC_Academy;User ID=admin;Password=admin";

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                string sql = "INSERT INTO Registration(Name,Id,Password,Address,Contact_number,Birth_of_date,Email) VALUES('" + Signup1.name + "','" + Signup1.id + "','" + Signup1.password + "','" + Signup1.address + "','" + Signup1.phonenum + "','" + Signup1.dob + "','" + Signup1.email + "')";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();

                string sql1 = "INSERT INTO Ol_Results(Year,Mathematics,Science,Sinhala,English,History,Religion,Bucket_1,Bucket_2,Bucket_3,Id) VALUES('" + Signup2.OLyear + "','" + Signup2.maths + "','" + Signup2.science + "','" + Signup2.sinhala + "','" + Signup2.OLenglish + "','" + Signup2.history + "','" + Signup2.religion + "','" + Signup2.OLbucket1 + "','" + Signup2.OLbucket2 + "','" + Signup2.OLbucket3 + "','" + Signup1.id + "')";
                SqlCommand cmd1 = new SqlCommand(sql1, cnn);
                cmd1.ExecuteNonQuery();

                string sql2 = "INSERT INTO Al_Results(Year,Stream,Bucket_1,Bucket_2,Bucket_3,English,Id) VALUES('" + Signup3.ALyear + "','" + Signup3.ALstream + "','" + Signup3.ALbucket1 + "','" + Signup3.ALbucket2 + "','" + Signup3.ALbucket3 + "','" + Signup3.ALenglish + "','" + Signup1.id + "')";
                SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                cmd2.ExecuteNonQuery();

                string sql3 = "INSERT INTO Other_Qualifications(Category,Name,Reason,Year,Id) VALUES('" + Signup4.OQcategory1 + "','" + Signup4.OQname1 + "','" + Signup4.OQreason1 + "','" + Signup4.OQyear1 + "','" + Signup1.id + "')";
                SqlCommand cmd3 = new SqlCommand(sql3, cnn);
                cmd3.ExecuteNonQuery();

                string sql4 = "INSERT INTO Other_Qualifications1(Category,Name,Reason,Year,Id) VALUES('" + Signup5.OQcategory2 + "','" + Signup5.OQname2 + "','" + Signup5.OQreason2 + "','" + Signup5.OQyear2 + "','" + Signup1.id + "')";
                SqlCommand cmd4 = new SqlCommand(sql4, cnn);
                cmd4.ExecuteNonQuery();

                string sql5 = "INSERT INTO Course(Course_school,Course_name,Id) VALUES('" + Signup6.Courseschool + "','" + Signup6.Coursecourse + "','" + Signup1.id + "')";
                SqlCommand cmd5 = new SqlCommand(sql5, cnn);
                cmd5.ExecuteNonQuery();

                string sql6 = "INSERT INTO Payment(Method,Type,Card_no,Expire_date,Cvc,Id) VALUES('" + Signup7.method + "','" + Signup7.type + "','" + Signup7.cardno + "','" + Signup7.expiredate + "','" + Signup7.cvc + "','" + Signup1.id + "')";
                SqlCommand cmd6 = new SqlCommand(sql6, cnn);
                cmd6.ExecuteNonQuery();

                cnn.Close();

                this.Hide();
                Signup8 signup8 = new Signup8();
                signup8.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Enter the Valid Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Signup9_Load(object sender, EventArgs e)
        {
            try
            { 
                Random random = new Random();
                randomcode2 = (random.Next(999999)).ToString();

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("senithumeshac@gmail.com");
                mail.To.Add(Signup1.email);
                mail.Subject = "Password reset code";
                mail.Body = "Here is your code : " + randomcode2;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("senithumeshac@gmail.com", "senithumeshac#");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
