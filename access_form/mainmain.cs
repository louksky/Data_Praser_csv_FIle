using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace access_form
{
    public partial class mainmain : Form
    {
        public mainmain()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new chartshow().Show();
        }
    }
}
