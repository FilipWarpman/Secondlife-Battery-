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
        public SecondLifeDataSetClient()
        {
            InitializeComponent();
        }

        private void DataGridViewElectricityPrices(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void GetResult_Click(object sender, EventArgs e)
        {
            errorMsgTextBox.Clear();
            dal.ClearData();
            try
            {
                if (comboBox.SelectedItem.Equals("SE1"))
                {
                    dataGridViewElectricityPrices.DataSource = dal.GetElectricityPriceSE1();
                    DataGridViewColumn columnElectricityPriceDate = dataGridViewElectricityPrices.Columns[0];
                    ListSortDirection listSortDirection = (ListSortDirection)0;
                    dataGridViewElectricityPrices.Sort(columnElectricityPriceDate, listSortDirection);
                    DataGridViewColumn columnElectricityPrice = dataGridViewElectricityPrices.Columns[1];
                    columnElectricityPrice.Width = 120;
                    dataGridViewWeather.DataSource = await dal.GetWeatherAsync();
                    DataGridViewColumn columnDate = dataGridViewWeather.Columns[3];
                    columnDate.Width = 250;
                }
                else if (comboBox.SelectedItem.Equals("SE2"))
                {
                    dataGridViewElectricityPrices.DataSource = dal.GetElectricityPriceSE2();
                    DataGridViewColumn columnElectricityPriceDate = dataGridViewElectricityPrices.Columns[0];
                    ListSortDirection listSortDirection = (ListSortDirection)0;
                    dataGridViewElectricityPrices.Sort(columnElectricityPriceDate, listSortDirection);
                    DataGridViewColumn columnElectricityPrice = dataGridViewElectricityPrices.Columns[1];
                    columnElectricityPrice.Width = 120;
                    dataGridViewWeather.DataSource = await dal.GetWeatherAsync();
                    DataGridViewColumn columnDate = dataGridViewWeather.Columns[3];
                    columnDate.Width = 250;
                }
                else if (comboBox.SelectedItem.Equals("SE3"))
                {
                    dataGridViewElectricityPrices.DataSource = dal.GetElectricityPriceSE3();
                    DataGridViewColumn columnElectricityPriceDate = dataGridViewElectricityPrices.Columns[0];
                    ListSortDirection listSortDirection = (ListSortDirection)0;
                    dataGridViewElectricityPrices.Sort(columnElectricityPriceDate, listSortDirection);
                    DataGridViewColumn columnElectricityPrice = dataGridViewElectricityPrices.Columns[1];
                    columnElectricityPrice.Width = 120;
                    dataGridViewWeather.DataSource = await dal.GetWeatherAsync();
                    DataGridViewColumn columnDate = dataGridViewWeather.Columns[3];
                    columnDate.Width = 250;
                }
                else if (comboBox.SelectedItem.Equals("SE4"))
                {
                    dataGridViewElectricityPrices.DataSource = dal.GetElectricityPriceSE3();
                    DataGridViewColumn columnElectricityPriceDate = dataGridViewElectricityPrices.Columns[0];
                    ListSortDirection listSortDirection = (ListSortDirection)0;
                    dataGridViewElectricityPrices.Sort(columnElectricityPriceDate, listSortDirection);
                    DataGridViewColumn columnElectricityPrice = dataGridViewElectricityPrices.Columns[1];
                    columnElectricityPrice.Width = 120;
                    dataGridViewWeather.DataSource = await dal.GetWeatherAsync();
                    DataGridViewColumn columnDate = dataGridViewWeather.Columns[3];
                    columnDate.Width = 250;
                }
                else
                {
                    errorMsgTextBox.AppendText("We don´t know what is wrong");
                }
        }
            catch (Exception ex)
            {
                
            }

}

        private void SecondLifeDataSetClient_Load(object sender, EventArgs e)
        {

        }
    }
}
