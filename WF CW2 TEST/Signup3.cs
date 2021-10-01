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
    public partial class Signup3 : Form
    {
        public static char ALbucket1;
        public static char ALbucket2;
        public static char ALbucket3;
        public static int ALyear;
        public static string ALstream;
        public static char ALenglish;

        public Signup3()
        {
            InitializeComponent();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Signup2 signup2 = new Signup2();
            signup2.Show();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if ((txtALbucket1.Text == "A" || txtALbucket1.Text == "B" || txtALbucket1.Text == "C" || txtALbucket1.Text == "S" || txtALbucket1.Text == "F") &&
                       (txtALbucket2.Text == "A" || txtALbucket2.Text == "B" || txtALbucket2.Text == "C" || txtALbucket2.Text == "S" || txtALbucket2.Text == "F") &&
                       (txtALbucket3.Text == "A" || txtALbucket3.Text == "B" || txtALbucket3.Text == "C" || txtALbucket3.Text == "S" || txtALbucket3.Text == "F") &&
                       (txtALenglish.Text == "A" || txtALenglish.Text == "B" || txtALenglish.Text == "C" || txtALenglish.Text == "S" || txtALenglish.Text == "F"))
                {
                    ALbucket1 = Convert.ToChar(txtALbucket1.Text);
                    ALbucket2 = Convert.ToChar(txtALbucket2.Text);
                    ALbucket3 = Convert.ToChar(txtALbucket3.Text);
                    ALyear = Convert.ToInt32(txtALyear.Text);
                    ALenglish = Convert.ToChar(txtALenglish.Text);

                    if (comboBox1.SelectedIndex == 0)
                    {
                        ALstream = comboBox1.Text;
                        this.Hide();
                        Signup4 signup4 = new Signup4();
                        signup4.ShowDialog();
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        ALstream = comboBox1.Text;
                        this.Hide();
                        Signup4 signup4 = new Signup4();
                        signup4.ShowDialog();
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        ALstream = comboBox1.Text;
                        this.Hide();
                        Signup4 signup4 = new Signup4();
                        signup4.ShowDialog();
                    }
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        ALstream = comboBox1.Text;
                        this.Hide();
                        Signup4 signup4 = new Signup4();
                        signup4.ShowDialog();
                    }
                    else if(comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select A Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ALstream = comboBox1.Text;
                        this.Hide();
                        Signup4 signup4 = new Signup4();
                        signup4.ShowDialog();
                    }
  
                    
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Results", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtALyear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtALyear.Text))
            {
                e.Cancel = true;
                txtALyear.Focus();
                errorProvider1.SetError(txtALyear, "Please Enter The Year");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtALyear, null);
            }
        }

        private void txtALenglish_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtALenglish.Text))
            {
                e.Cancel = true;
                txtALenglish.Focus();
                errorProvider1.SetError(txtALenglish, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtALenglish, null);
            }
        }

        private void txtALbucket1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtALbucket1.Text))
            {
                e.Cancel = true;
                txtALbucket1.Focus();
                errorProvider1.SetError(txtALbucket1, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtALbucket1, null);
            }
        }

        private void txtALbucket2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtALbucket2.Text))
            {
                e.Cancel = true;
                txtALbucket2.Focus();
                errorProvider1.SetError(txtALbucket2, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtALbucket2, null);
            }
        }

        private void txtALbucket3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtALbucket3.Text))
            {
                e.Cancel = true;
                txtALbucket3.Focus();
                errorProvider1.SetError(txtALbucket3, "Please Enter Your Results");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtALbucket3, null);
            }
        }

        private void txtALyear_KeyPress(object sender, KeyPressEventArgs e)
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
