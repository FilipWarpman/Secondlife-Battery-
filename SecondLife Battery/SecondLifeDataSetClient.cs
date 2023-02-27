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
        DataAccessLayer dal = new DataAccessLayer();
        DataTable dataFromSE4 = new DataTable();
        DataTable dataFromSE3 = new DataTable();
        DataTable dataFromSE2 = new DataTable();
        DataTable dataFromSE1 = new DataTable();
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
        private async void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dal.ClearWeatherData();
            if (comboBox.SelectedItem.Equals("SE1"))
            {
                dataGridViewElectricityPrices.DataSource = dataFromSE1;
                DataGridViewColumn columnElectricityPriceDate = dataGridViewElectricityPrices.Columns[0];
                ListSortDirection listSortDirection = (ListSortDirection)0;
                dataGridViewElectricityPrices.Sort(columnElectricityPriceDate, listSortDirection);
                DataGridViewColumn columnElectricityPrice = dataGridViewElectricityPrices.Columns[1];
                columnElectricityPrice.Width = 120;
                dataGridViewWeather.DataSource = await dal.GetWeatherAsync(comboBox.Text);
                DataGridViewColumn columnDate = dataGridViewWeather.Columns[3];
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
                dataGridViewWeather.DataSource = await dal.GetWeatherAsync(comboBox.Text);
                DataGridViewColumn columnDate = dataGridViewWeather.Columns[3];
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
                dataGridViewWeather.DataSource = await dal.GetWeatherAsync(comboBox.Text);
                DataGridViewColumn columnDate = dataGridViewWeather.Columns[3];
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
                dataGridViewWeather.DataSource = await dal.GetWeatherAsync(comboBox.Text);
                DataGridViewColumn columnDate = dataGridViewWeather.Columns[3];
                columnDate.Width = 250;
            }
            else
            {
                errorMsgTextBox.AppendText("Choose an area where you want your data from");
            }

        }

        private void SecondLifeDataSetClient_Load(object sender, EventArgs e)
        {

        }

        
    }
}
