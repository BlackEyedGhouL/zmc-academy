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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup1 signup1 = new Signup1();
            signup1.ShowDialog();
        }

        private void btnaboutus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aboutus aboutus = new Aboutus();
            aboutus.ShowDialog();
        }

        private void btncontactus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contactus contactus = new Contactus();
            contactus.ShowDialog();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin1 signin1 = new Signin1();
            signin1.ShowDialog();
        }
    }
}
