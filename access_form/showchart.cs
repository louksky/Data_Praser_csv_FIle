using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace access_form
{
    public partial class showchart : Form
    {
        double max = 0.0, min = 111110.0, avg=0.0;
        public showchart(Chart c)
        {
            
           InitializeComponent();
            try
            {
                foreach (DataPoint dp in c.Series[0].Points)
                {
                    chart1.Series[0].Points.AddXY(dp.XValue, dp.YValues[0]);
                    chart1.Series[1].Points.AddXY(dp.XValue, dp.YValues[0]);
                    chart1.Series[2].Points.AddXY(dp.XValue, dp.YValues[0]);
                    avg += dp.YValues[0];
                    if (max < dp.YValues[0]) max = dp.YValues[0];
                    if (min > dp.YValues[0]) min = dp.YValues[0];
                }
                avg /= chart1.Series[0].Points.Count;

                chart1.Series[0].Name = c.Series[0].Name;

                label1.Text = "AVRAGE-> " + avg;
                label2.Text = "MAX-> " + max;
                label3.Text = "MIX-> " + min;
            }
            catch (Exception v)
            {
                return;
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
