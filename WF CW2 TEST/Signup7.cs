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
    public partial class Signup7 : Form
    {
        public static string method;
        public static string type;
        public static string expiredate;
        public static int cvc;
        public static int cardno;

        public Signup7()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Signup6 signup6 = new Signup6();
            signup6.Show();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                expiredate = dateTimePicker1.Value.ToString();
                cvc = Convert.ToInt32(txtcvc.Text);
                cardno = Convert.ToInt32(txtcardno.Text);

                if (cmbmethod.SelectedIndex == 0)
                {
                    method = cmbmethod.Text;
                    if (cmbtype.SelectedIndex == 0)
                    {
                        type = cmbtype.Text;
                        if ( MessageBox.Show("By creating a ZMC Academy account , you are agreeing to be bound by the terms of use.", "Terms of use", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Hide();
                            Signup9 signup9 = new Signup9();
                            signup9.ShowDialog();
                        }
                    }
                    else if (cmbtype.SelectedIndex == 1)
                    {
                        type = cmbtype.Text;
                        if (MessageBox.Show("By creating a ZMC Academy account , you are agreeing to be bound by the terms of use.", "Terms of use", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Hide();
                            Signup9 signup9 = new Signup9();
                            signup9.ShowDialog();
                        }
                    }
                    else if (cmbtype.SelectedIndex == 2)
                    {
                        type = cmbtype.Text;
                        if (MessageBox.Show("By creating a ZMC Academy account , you are agreeing to be bound by the terms of use.", "Terms of use", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Hide();
                            Signup9 signup9 = new Signup9();
                            signup9.ShowDialog();
                        }
                    }
                    else if (cmbtype.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select A Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        type = cmbtype.Text;
                        if (MessageBox.Show("By creating a ZMC Academy account , you are agreeing to be bound by the terms of use.", "Terms of use", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Hide();
                            Signup9 signup9 = new Signup9();
                            signup9.ShowDialog();
                        }
                    }
                }
                else if (cmbmethod.SelectedItem == null)
                {
                    MessageBox.Show("Please Select A Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    method = cmbmethod.Text;
                    if (cmbtype.SelectedIndex == 0)
                    {
                        type = cmbtype.Text;
                        if (MessageBox.Show("By creating a ZMC Academy account , you are agreeing to be bound by the terms of use.", "Terms of use", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Hide();
                            Signup9 signup9 = new Signup9();
                            signup9.ShowDialog();
                        }
                    }
                    else if (cmbtype.SelectedIndex == 1)
                    {
                        type = cmbtype.Text;
                        if (MessageBox.Show("By creating a ZMC Academy account , you are agreeing to be bound by the terms of use.", "Terms of use", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Hide();
                            Signup9 signup9 = new Signup9();
                            signup9.ShowDialog();
                        }
                    }
                    else if (cmbtype.SelectedIndex == 2)
                    {
                        type = cmbtype.Text;
                        if (MessageBox.Show("By creating a ZMC Academy account , you are agreeing to be bound by the terms of use.", "Terms of use", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Hide();
                            Signup9 signup9 = new Signup9();
                            signup9.ShowDialog();
                        }
                    }
                    else if (cmbtype.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select A Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        type = cmbtype.Text;
                        if (MessageBox.Show("By creating a ZMC Academy account , you are agreeing to be bound by the terms of use.", "Terms of use", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Hide();
                            Signup9 signup9 = new Signup9();
                            signup9.ShowDialog();
                        }
                    }
                }
            }
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcardno_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcardno.Text))
            {
                e.Cancel = true;
                txtcardno.Focus();
                errorProvider1.SetError(txtcardno, "Please Enter Your Card Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtcardno, null);
            }
        }

        private void txtcvc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcvc.Text))
            {
                e.Cancel = true;
                txtcvc.Focus();
                errorProvider1.SetError(txtcvc, "Please Enter Your CVC");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtcvc, null);
            }
        }

        private void txtcardno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Valid Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcvc_KeyPress(object sender, KeyPressEventArgs e)
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
