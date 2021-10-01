using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW2_TEST
{
    public partial class Signup2 : Form
    {
        public static int OLyear;
        public static char maths;
        public static char science;
        public static char sinhala;
        public static char OLenglish;
        public static char religion;
        public static char history;
        public static char OLbucket1;
        public static char OLbucket2;
        public static char OLbucket3;

        public Signup2()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Signup1 signup1 = new Signup1();
            signup1.Show();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if ((txtmaths.Text == "A" || txtmaths.Text == "B" || txtmaths.Text == "C" || txtmaths.Text == "S" || txtmaths.Text == "F" )&&
                       (txtscience.Text == "A" || txtscience.Text == "B" || txtscience.Text == "C" || txtscience.Text == "S" || txtscience.Text == "F") &&
                       (txtsinhala.Text == "A" || txtsinhala.Text == "B" || txtsinhala.Text == "C" || txtsinhala.Text == "S" || txtsinhala.Text == "F") &&
                       (txtOLenglish.Text == "A" || txtOLenglish.Text == "B" || txtOLenglish.Text == "C" || txtOLenglish.Text == "S" || txtOLenglish.Text == "F" ) &&
                       (txtreligion.Text == "A" || txtreligion.Text == "B" || txtreligion.Text == "C" || txtreligion.Text == "S" || txtreligion.Text == "F") &&
                       (txthistory.Text == "A" || txthistory.Text == "B" || txthistory.Text == "C" || txthistory.Text == "S" || txthistory.Text == "F") &&
                       (txtOLbucket1.Text == "A" || txtOLbucket1.Text == "B" || txtOLbucket1.Text == "C" || txtOLbucket1.Text == "S" || txtOLbucket1.Text == "F") &&
                       (txtOLbucket2.Text == "A" || txtOLbucket2.Text == "B" || txtOLbucket2.Text == "C" || txtOLbucket2.Text == "S" || txtOLbucket2.Text == "F") &&
                       (txtOLbucket3.Text == "A" || txtOLbucket3.Text == "B" || txtOLbucket3.Text == "C" || txtOLbucket3.Text == "S" || txtOLbucket3.Text == "F"))
                {
                    maths = Convert.ToChar(txtmaths.Text);
                    science = Convert.ToChar(txtscience.Text);
                    sinhala = Convert.ToChar(txtsinhala.Text);
                    OLenglish = Convert.ToChar(txtOLenglish.Text);
                    religion = Convert.ToChar(txtreligion.Text);
                    history = Convert.ToChar(txthistory.Text);
                    OLbucket1 = Convert.ToChar(txtOLbucket1.Text);
                    OLbucket2 = Convert.ToChar(txtOLbucket2.Text);
                    OLbucket3 = Convert.ToChar(txtOLbucket3.Text);
                    OLyear = Convert.ToInt32(txtOLyear.Text);
                    this.Hide();
                    Signup3 signup3 = new Signup3();
                    signup3.ShowDialog();
                }                
                else
                {
                    MessageBox.Show("Please Enter Valid Results", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }               
            }          
        }



        

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOLyear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOLyear.Text))
            {
                e.Cancel = true;
                txtOLyear.Focus();
                errorProvider1.SetError(txtOLyear, "Please Enter The Year");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOLyear, null);
            }
        }

        private void txtmaths_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtmaths.Text))
            {
                e.Cancel = true;
                txtmaths.Focus();
                errorProvider1.SetError(txtmaths, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtmaths, null);
            }
        }

        private void txtsinhala_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtsinhala.Text))
            {
                e.Cancel = true;
                txtsinhala.Focus();
                errorProvider1.SetError(txtsinhala, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtsinhala, null);
            }
        }

        private void txtOLenglish_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOLenglish.Text))
            {
                e.Cancel = true;
                txtOLenglish.Focus();
                errorProvider1.SetError(txtOLenglish, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOLenglish, null);
            }
        }

        private void txtreligion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtreligion.Text))
            {
                e.Cancel = true;
                txtreligion.Focus();
                errorProvider1.SetError(txtreligion, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtreligion, null);
            }
        }

        private void txthistory_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txthistory.Text))
            {
                e.Cancel = true;
                txthistory.Focus();
                errorProvider1.SetError(txthistory, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txthistory, null);
            }
        }

        private void txtOLbucket1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOLbucket1.Text))
            {
                e.Cancel = true;
                txtOLbucket1.Focus();
                errorProvider1.SetError(txtOLbucket1, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOLbucket1, null);
            }
        }

        private void txtOLbucket2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOLbucket2.Text))
            {
                e.Cancel = true;
                txtOLbucket2.Focus();
                errorProvider1.SetError(txtOLbucket2, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOLbucket2, null);
            }
        }

        private void txtOLbucket3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOLbucket3.Text))
            {
                e.Cancel = true;
                txtOLbucket3.Focus();
                errorProvider1.SetError(txtOLbucket3, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOLbucket3, null);
            }
        }

        private void txtscience_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtscience.Text))
            {
                e.Cancel = true;
                txtscience.Focus();
                errorProvider1.SetError(txtscience, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtscience, null);
            }
        }

        private void txtOLyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
