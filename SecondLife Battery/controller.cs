using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing; 

namespace SecondLife_Battery
{
    public class Controller
    {

        private Form1 form1;

        public Controller()
        {
            form1 = new Form1();
        }

        public void UpdateChartData()
        {
            Chart chart = form1.MyChart;
            // Add data to the chart
           // chart.Series[0].Points.AddXY(...);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Series.Clear();

            // Create a new series for the chart
            Series series1 = new Series
            {
                Name = "Series1",
                Color = Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.StackedBar
            };

            // Add data points to the series
            series1.Points.Add(new DataPoint(1, 10));
            series1.Points.Add(new DataPoint(2, 20));
            series1.Points.Add(new DataPoint(3, 30));
            series1.Points.Add(new DataPoint(4, 40));

            // Add the series to the chart
            Chart.Series.Add(series1);

            // Find the data point with the lowest value
            DataPoint minPoint = series1.Points.FindMinByValue();

            // Change the color of the data point with the lowest value
            minPoint.Color = Color.Red;

            // Change the color of all other data points to the default color
            foreach (DataPoint point in series1.Points)
            {
                if (point != minPoint)
                {
                    point.Color = Color.Green;
                }
            }
        }
    }
}

 
