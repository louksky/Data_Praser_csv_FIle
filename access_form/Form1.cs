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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CarsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sqloukDataSet);

        }

        private void CarsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sqloukDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sqloukDataSet.cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.sqloukDataSet.cars);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new query().Show();
        }
    }
}
