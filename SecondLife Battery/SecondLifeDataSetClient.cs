using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLife_Battery
{
    public partial class SecondLifeDataSetClient : Form
    {
        List<Panel> listPanel = new List<Panel>();
        DataAccessLayer dal = new DataAccessLayer();
        DataTable dataFromSE4 = new DataTable();
        DataTable dataFromSE3 = new DataTable();
        DataTable dataFromSE2 = new DataTable();
        DataTable dataFromSE1 = new DataTable();
        DataTable weatherdataFromSE4 = new DataTable();
        DataTable weatherdataFromSE3 = new DataTable();
        DataTable weatherdataFromSE2 = new DataTable();
        DataTable weatherdataFromSE1 = new DataTable();
        public SecondLifeDataSetClient()
        {
            InitializeComponent();
            dataFromSE4 = dal.GetElectricityPriceSE4();
            dataFromSE3 = dal.GetElectricityPriceSE3();
            dataFromSE2 = dal.GetElectricityPriceSE2();
            dataFromSE1 = dal.GetElectricityPriceSE1();

        }

        private void DataGridViewElectricityPrices(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selected item: " + comboBox.SelectedItem.ToString());
            Console.WriteLine("Data from SE1: " + weatherdataFromSE1.Rows.Count.ToString() + " rows");
            Console.WriteLine("Data from SE2: " + weatherdataFromSE2.Rows.Count.ToString() + " rows");
            Console.WriteLine("Data from SE3: " + weatherdataFromSE3.Rows.Count.ToString() + " rows");
            Console.WriteLine("Data from SE4: " + weatherdataFromSE4.Rows.Count.ToString() + " rows");
            if (comboBox.SelectedItem.Equals("SE1"))
            {
                dataGridViewElectricityPrices.DataSource = dataFromSE1;
                DataGridViewColumn columnElectricityPriceDate = dataGridViewElectricityPrices.Columns[0];
                ListSortDirection listSortDirection = (ListSortDirection)0;
                dataGridViewElectricityPrices.Sort(columnElectricityPriceDate, listSortDirection);
                DataGridViewColumn columnElectricityPrice = dataGridViewElectricityPrices.Columns[1];
                columnElectricityPrice.Width = 120;
                dataGridViewWeather.DataSource = weatherdataFromSE1;
                DataGridViewColumn columnDate = dataGridViewWeather.Columns[4];
                columnDate.Width = 250;
            }
            else if (comboBox.SelectedItem.Equals("SE2"))
            {
                dataGridViewElectricityPrices.DataSource = dataFromSE2;
                DataGridViewColumn columnElectricityPriceDate = dataGridViewElectricityPrices.Columns[0];
                ListSortDirection listSortDirection = (ListSortDirection)0;
                dataGridViewElectricityPrices.Sort(columnElectricityPriceDate, listSortDirection);
                DataGridViewColumn columnElectricityPrice = dataGridViewElectricityPrices.Columns[1];
                columnElectricityPrice.Width = 120;
                dataGridViewWeather.DataSource = weatherdataFromSE2;
                DataGridViewColumn columnDate = dataGridViewWeather.Columns[4];
                columnDate.Width = 250;
            }
            else if (comboBox.SelectedItem.Equals("SE3"))
            {
                dataGridViewElectricityPrices.DataSource = dataFromSE3;
                DataGridViewColumn columnElectricityPriceDate = dataGridViewElectricityPrices.Columns[0];
                ListSortDirection listSortDirection = (ListSortDirection)0;
                dataGridViewElectricityPrices.Sort(columnElectricityPriceDate, listSortDirection);
                DataGridViewColumn columnElectricityPrice = dataGridViewElectricityPrices.Columns[1];
                columnElectricityPrice.Width = 120;
                dataGridViewWeather.DataSource = weatherdataFromSE3;
                DataGridViewColumn columnDate = dataGridViewWeather.Columns[4];
                columnDate.Width = 250;
            }
            else if (comboBox.SelectedItem.Equals("SE4"))
            {
                dataGridViewElectricityPrices.DataSource = dataFromSE4;
                DataGridViewColumn columnElectricityPriceDate = dataGridViewElectricityPrices.Columns[0];
                ListSortDirection listSortDirection = (ListSortDirection)0;
                dataGridViewElectricityPrices.Sort(columnElectricityPriceDate, listSortDirection);
                DataGridViewColumn columnElectricityPrice = dataGridViewElectricityPrices.Columns[1];
                columnElectricityPrice.Width = 120;
                dataGridViewWeather.DataSource = weatherdataFromSE4;
                DataGridViewColumn columnDate = dataGridViewWeather.Columns[4];
                columnDate.Width = 250;
            }
            else
            {
                errorMsgTextBox.AppendText("Choose an area where you want your data from");
            }

        }

        private void SecondLifeDataSetClient_Load(object sender, EventArgs e)
        {
            WelcomePanel.BringToFront();
        }

        private async void NextButton_Click(object sender, EventArgs e)
        {
            weatherdataFromSE1 = await dal.GetWeatherAsyncSE1();
            weatherdataFromSE2 = await dal.GetWeatherAsyncSE2();
            weatherdataFromSE3 = await dal.GetWeatherAsyncSE3();
            weatherdataFromSE4 = await dal.GetWeatherAsyncSE4();
            ShowDataPanel.Show();
            ShowDataPanel.BringToFront();           
        }
    }
}
