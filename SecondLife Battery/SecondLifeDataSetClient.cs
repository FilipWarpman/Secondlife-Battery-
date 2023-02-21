using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            dal.ClearData();
            if (comboBox.SelectedItem.Equals("SE1"))
            {
                DateTime date = dateTimePicker.Value;
                dal.SetDate(date);
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
                DateTime date = dateTimePicker.Value;
                dal.SetDate(date);
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
                DateTime date = dateTimePicker.Value;
                dal.SetDate(date);
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
                DateTime date = dateTimePicker.Value;
                dal.SetDate(date);
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
                errorMsgTextBox.AppendText("Something is wrong");
            }

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SecondLifeDataSetClient_Load(object sender, EventArgs e)
        {

        }
    }
}
