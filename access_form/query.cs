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
    public partial class query : Form
    {
        public query()
        {
            InitializeComponent();
        }

        private void Query_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sqloukDataSet.GetDeatails' table. You can move, or remove it, as needed.
            this.getDeatailsTableAdapter.Fill(this.sqloukDataSet.GetDeatails);

        }
    }
}
