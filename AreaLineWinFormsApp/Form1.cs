using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace AreaLineWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var chart = new TChart();
            var series1 = new Area();
            series1.Add(1, 2);
            series1.Add(2, 3);
            series1.Add(3, 6);
            var series2 = new Area();
            series2.Add(1, 1);
            series2.Add(2, 2);
            series2.Add(3, 5);
            chart.Series.Add(series1);
            chart.Series.Add(series2);
            chart.Export.Image.PNG.Width = 800;
            chart.Export.Image.PNG.Height = 600;
            chart.Export.Image.PNG.Save(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "chart.png"));
        }
    }
}
