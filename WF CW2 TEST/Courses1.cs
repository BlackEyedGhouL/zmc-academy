using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW2_TEST
{
    public partial class Courses1 : UserControl
    {
        public Courses1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                courses21.Hide();
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                courses21.Show();
            }
        }

        private void Courses1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
    }
}
