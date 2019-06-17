using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace access_form
{
    public partial class chartshow : Form
    {
        string file = "myfile.csv";
        public chartshow()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if(openFileDialog1.CheckFileExists){
                file = openFileDialog1.FileName;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //working on csv file 
            try
            {
                using (var reader = new StreamReader(@""+file))
                {


                    List<string> listA = new List<string>();
                    List<string> listB = new List<string>();
                    int i = 0;
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    chart1.Series[0].Name = values[0];
                    chart2.Series[0].Name = values[1];
                    chart3.Series[0].Name = values[2];
                    chart4.Series[0].Name = values[3];
                    chart5.Series[0].Name = values[4];
                    chart6.Series[0].Name = values[5];
                    chart7.Series[0].Name = values[6];
                    chart8.Series[0].Name = values[7];
                    chart9.Series[0].Name = values[8];
                    chart10.Series[0].Name = values[9];
                    chart11.Series[0].Name = values[10];
                    chart12.Series[0].Name = values[11];
                    chart13.Series[0].Name = values[12];
                    chart14.Series[0].Name = values[13];
                    chart15.Series[0].Name = values[14];
                    chart16.Series[0].Name = values[15];
                    chart17.Series[0].Name = values[16];
                    chart18.Series[0].Name = values[17];


                    while (!reader.EndOfStream)
                    {
                         line = reader.ReadLine();
                         values = line.Split(',');
                        try {
                            if ((vanc.Checked && values[18] == "van") || (saabc.Checked && values[18] == "saab") || (busc.Checked && values[18] == "bus") || (oplc.Checked && values[18] == "opel"))
                            {
                                chart1.Series[0].Points.AddXY((double)i++, double.Parse(values[0]));
                                chart2.Series[0].Points.AddXY((double)i++, double.Parse(values[1]));
                                chart3.Series[0].Points.AddXY((double)i++, double.Parse(values[2]));
                                chart4.Series[0].Points.AddXY((double)i++, double.Parse(values[3]));
                                chart5.Series[0].Points.AddXY((double)i++, double.Parse(values[4]));
                                chart6.Series[0].Points.AddXY((double)i++, double.Parse(values[5]));
                                chart7.Series[0].Points.AddXY((double)i++, double.Parse(values[6]));
                                chart8.Series[0].Points.AddXY((double)i++, double.Parse(values[7]));
                                chart9.Series[0].Points.AddXY((double)i++, double.Parse(values[8]));
                                chart10.Series[0].Points.AddXY((double)i++, double.Parse(values[9]));
                                chart11.Series[0].Points.AddXY((double)i++, double.Parse(values[10]));
                                chart12.Series[0].Points.AddXY((double)i++, double.Parse(values[11]));
                                chart13.Series[0].Points.AddXY((double)i++, double.Parse(values[12]));
                                chart14.Series[0].Points.AddXY((double)i++, double.Parse(values[13]));
                                chart15.Series[0].Points.AddXY((double)i++, double.Parse(values[14]));
                                chart16.Series[0].Points.AddXY((double)i++, double.Parse(values[15]));
                                chart17.Series[0].Points.AddXY((double)i++, double.Parse(values[16]));
                                chart18.Series[0].Points.AddXY((double)i++, double.Parse(values[17]));
                            }
                            else
                            {
                                continue;
                            }
                        }
                        catch (Exception)
                        {
                            

                            continue;
                        }
                       
                    }
                }
            }
            catch (Exception v)
            {
                
            }
        }

        private void Chart1_Click(object sender, EventArgs e)
        {
            new showchart(chart1).Show();
        }

        private void Chart8_Click(object sender, EventArgs e)
        {
            new showchart(chart8).Show();
        }

        private void Chart12_Click(object sender, EventArgs e)
        {
            new showchart(chart12).Show();
        }

        private void Chart16_Click(object sender, EventArgs e)
        {
            new showchart(chart16).Show();
        }

        private void Chart17_Click(object sender, EventArgs e)
        {
            new showchart(chart17).Show();
        }

        private void Chart2_Click(object sender, EventArgs e)
        {
            new showchart(chart2).Show();
        }

        private void Chart7_Click(object sender, EventArgs e)
        {
            new showchart(chart7).Show();
        }

        private void Chart11_Click(object sender, EventArgs e)
        {
            new showchart(chart11).Show();
        }

        private void Chart15_Click(object sender, EventArgs e)
        {
            new showchart(chart15).Show();
        }

        private void Chart4_Click(object sender, EventArgs e)
        {
            new showchart(chart4).Show();
        }

        private void Chart5_Click(object sender, EventArgs e)
        {
            new showchart(chart5).Show();
        }

        private void Chart9_Click(object sender, EventArgs e)
        {
            new showchart(chart9).Show();
        }

        private void Chart13_Click(object sender, EventArgs e)
        {
            new showchart(chart13).Show();
        }

        private void Chart18_Click(object sender, EventArgs e)
        {
            new showchart(chart18).Show();
        }

        private void Chart6_Click(object sender, EventArgs e)
        {
            new showchart(chart6).Show();
        }

        private void Chart3_Click(object sender, EventArgs e)
        {
            new showchart(chart3).Show();
        }

        private void Chart14_Click(object sender, EventArgs e)
        {
            new showchart(chart14).Show();
        }

        private void Chart10_Click(object sender, EventArgs e)
        {
            new showchart(chart10).Show();
        }
    }
}
