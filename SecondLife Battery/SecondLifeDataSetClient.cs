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
            DateTime date = dateTimePicker.Value;
            dal.SetDate(date);
            dataGridViewElectricityPrices.DataSource = dal.GetElectricityPrice();
            DataGridViewColumn columnElectricityPriceDate = dataGridViewElectricityPrices.Columns[0];
            ListSortDirection listSortDirection = (ListSortDirection)0;
            dataGridViewElectricityPrices.Sort(columnElectricityPriceDate, listSortDirection);
            DataGridViewColumn columnElectricityPrice = dataGridViewElectricityPrices.Columns[1];
            columnElectricityPrice.Width = 120;
            dataGridViewWeather.DataSource = await dal.GetWeatherAsync();
            DataGridViewColumn columnDate = dataGridViewWeather.Columns[3];
            columnDate.Width = 250;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
