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
    public partial class Signup8 : Form
    {
        public Signup8()
        {
            InitializeComponent();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Close();
            home home1 = new home();
            home1.ShowDialog();
        }
    }
}
