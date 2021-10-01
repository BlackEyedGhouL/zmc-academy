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
    public partial class Signup5 : Form
    {
        public static string OQname2;
        public static string OQreason2;
        public static int OQyear2;
        public static string OQcategory2;

        public Signup5()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Signup4 signup4 = new Signup4();
            signup4.Show();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                OQyear2 = Convert.ToInt32(txtOQyear.Text);
                OQname2 = txtOQname.Text;
                OQreason2 = txtOQreason.Text;
                if (comboBox1.SelectedIndex == 0)
                {
                    OQcategory2 = comboBox1.Text;
                    this.Hide();
                    Signup6 signup6 = new Signup6();
                    signup6.ShowDialog();
                }
                else if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please Select A Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    OQcategory2 = comboBox1.Text;
                    this.Hide();
                    Signup6 signup6 = new Signup6();
                    signup6.ShowDialog();
                }           
            }
        }

        private void txtOQyear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOQyear.Text))
            {
                e.Cancel = true;
                txtOQyear.Focus();
                errorProvider1.SetError(txtOQyear, "Please Enter The Year");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOQyear, null);
            }
        }

        private void txtOQname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOQname.Text))
            {
                e.Cancel = true;
                txtOQname.Focus();
                errorProvider1.SetError(txtOQname, "Please Enter The Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOQname, null);
            }
        }

        private void txtOQreason_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOQreason.Text))
            {
                e.Cancel = true;
                txtOQreason.Focus();
                errorProvider1.SetError(txtOQreason, "Please Enter The Reason");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOQreason, null);
            }
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOQyear_KeyPress(object sender, KeyPressEventArgs e)
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
