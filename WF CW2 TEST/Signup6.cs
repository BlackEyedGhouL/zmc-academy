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
    public partial class Signup6 : Form
    {
        public static string Courseschool;
        public static string Coursecourse;

        public Signup6()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (cmbschool.SelectedIndex == 0)
            {
                Courseschool = cmbschool.Text;
                if (cmbcourse.SelectedIndex == 0)
                {
                    Coursecourse = cmbcourse.Text;
                    this.Hide();
                    Signup7 signup7 = new Signup7();
                    signup7.ShowDialog();
                }
                else if (cmbcourse.SelectedItem == null)
                {
                    MessageBox.Show("Please Select A Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(cmbcourse.SelectedIndex == 1)
                {
                    Coursecourse = cmbcourse.Text;
                    this.Hide();
                    Signup7 signup7 = new Signup7();
                    signup7.ShowDialog();
                }
                else
                {
                    Coursecourse = cmbcourse.Text;
                    this.Hide();
                    Signup7 signup7 = new Signup7();
                    signup7.ShowDialog();
                }
            }
            else  if (cmbschool.SelectedItem == null)
            {
                MessageBox.Show("Please Select A Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Courseschool = cmbschool.Text;
                if (cmbcourse.SelectedIndex == 0)
                {
                    Coursecourse = cmbcourse.Text;
                    this.Hide();
                    Signup7 signup7 = new Signup7();
                    signup7.ShowDialog();
                }
                else if (cmbcourse.SelectedItem == null)
                {
                    MessageBox.Show("Please Select A Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbcourse.SelectedIndex == 1)
                {
                    Coursecourse = cmbcourse.Text;
                    this.Hide();
                    Signup7 signup7 = new Signup7();
                    signup7.ShowDialog();
                }
                else
                {
                    Coursecourse = cmbcourse.Text;
                    this.Hide();
                    Signup7 signup7 = new Signup7();
                    signup7.ShowDialog();
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Signup4 signup4 = new Signup4();
            signup4.Show();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
