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
    public partial class Pastpapers1 : UserControl
    {
        public Pastpapers1()
        {
            InitializeComponent();
        }

        private void Pastpapers1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtaddeddate.Text = DateTime.Now.ToLongDateString();

            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS; Initial Catalog = ZMC_Academy; User ID = admin; Password = admin";

            cnn = new SqlConnection(connectionString);

            cnn.Open();
            String sql = "Select*from Pastpapers";
            SqlCommand cmd = new SqlCommand(sql, cnn);

            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            ada.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            cnn.Close();
        }

        public static string P_id;
        public static String Return_date;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                P_id = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }
            panel1.Visible = true;
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS; Initial Catalog = ZMC_Academy; User ID = admin; Password = admin";

            cnn = new SqlConnection(connectionString);

            cnn.Open();
            String sql = "Select*from Pastpapers where P_id =" + P_id + "";
            SqlCommand cmd = new SqlCommand(sql, cnn);

            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds);

            txtsubject.Text = ds.Tables[0].Rows[0][1].ToString();
            txtpaperid.Text = ds.Tables[0].Rows[0][0].ToString();
            txtyear.Text = ds.Tables[0].Rows[0][2].ToString();

            cnn.Close();
        }

        private void txtsearchbar_TextChanged(object sender, EventArgs e)
        {
            if (txtsearchbar.Text != "")
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS; Initial Catalog = ZMC_Academy; User ID = admin; Password = admin";

                cnn = new SqlConnection(connectionString);

                cnn.Open();
                String sql = "Select*from Pastpapers where Subject LIKE '" + txtsearchbar.Text + "%'";
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
                String sql = "Select*from Pastpapers";
                SqlCommand cmd = new SqlCommand(sql, cnn);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                cnn.Close();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsearchbar.Clear();
            panel1.Visible = false;
        }

        private void btnaddtolist_Click(object sender, EventArgs e)
        {           
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            Return_date = Convert.ToString(dateTimePicker2.Value);

            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source = SENITHUMESHA\SQLEXPRESS;Initial catalog = ZMC_Academy;User ID=admin;Password=admin";

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            string sql = "INSERT INTO Pastpaperlist(P_addeddate,P_returndate,P_id,Id) VALUES('" + time.ToString(format) + "','" + Return_date + "','" + P_id + "','" + Signin1.signinID + "')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();

            MessageBox.Show("Your paper has been added to the list", "Past papers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
