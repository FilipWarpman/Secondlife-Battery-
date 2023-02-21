using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SecondLife_Battery
{
    public class DataAccessLayer
    {
        private string connectionString = @"Server=secondlife-battery.database.windows.net;Database=SecondLifeBatteryDB;user=SqlAdmin;password=Secondlife16;";
        private DateTime insertedDateValue;
        DataTable dataTable = new DataTable();
        DataTable dataTableWeather = new DataTable();
        ArrayList arrayWind = new ArrayList();
        ArrayList arrayCloud = new ArrayList();
        ArrayList arrayDate = new ArrayList();
        private double windSpeed;
        private double cloudCover;
        private DateTime weatherDate;
        public void SetDate(DateTime tempDateValue)
        {
            insertedDateValue = tempDateValue;
        }
        public DataTable GetElectricityPrice()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                DateTime date2 = insertedDateValue.AddDays(6);

                string sqlQuery = "SELECT Date, SE1 FROM ElectricityPrices WHERE Date between " + "'" + insertedDateValue.ToString("yyyy-MM-dd") + "'" + " and " + "'" + date2.ToString("yyyy-MM-dd") + "'";
                command.CommandText = sqlQuery;
                command.Connection = connection;


                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataTable);
                dataTable.Columns["SE1"].ColumnName = "Electricity Price";


            }

            return dataTable;
        }
        public void ClearData()
        {
            dataTable.Clear();
            dataTable.Columns.Clear();
            dataTableWeather.Clear();
            dataTableWeather.Columns.Clear();
        }

        public async Task<DataTable> GetWeatherAsync()
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Lund?unitGroup=us&key=QDN24AE8877YDJTTM3MYA7RDS&contentType=json");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode(); // Throw an exception if error

            var body = await response.Content.ReadAsStringAsync();

            dynamic weather = JsonConvert.DeserializeObject(body);

            foreach (var obj in weather.days)
            {
                string weather_Date = obj.datetime;
                try
                {
                    windSpeed = Convert.ToDouble(obj.windspeed);
                    cloudCover = Convert.ToDouble(obj.cloudcover);
                    weatherDate = Convert.ToDateTime(weather_Date);
                    arrayWind.Add(windSpeed);
                    arrayCloud.Add(cloudCover);
                    arrayDate.Add(weather_Date);
                }
                catch (Exception ex)
                {
                    
                }
            }
            DataColumn dataColumn;
            //Create Date column.
            dataColumn = new DataColumn();
            dataColumn.ColumnName = "Date";
            dataColumn.DataType = typeof(DateTime);
            dataTableWeather.Columns.Add(dataColumn);
            //Create Wind velocity column.
            dataColumn = new DataColumn();
            dataColumn.ColumnName = "Wind Velocity (km/h)";
            dataColumn.DataType = typeof(double);
            dataTableWeather.Columns.Add(dataColumn);
            //Create Cloud Coverage column.
            dataColumn = new DataColumn();
            dataColumn.ColumnName = "Cloud Coverage (%)";
            dataColumn.DataType = typeof(double);
            dataTableWeather.Columns.Add(dataColumn);            
            //Create the recommendation column.
            dataColumn = new DataColumn();
            dataColumn.ColumnName = "Charge?";
            dataColumn.DataType = typeof(string);
            dataTableWeather.Columns.Add(dataColumn);

            for (int i = 0; i < 7; i++)
            {
                DataRow row = dataTableWeather.NewRow();
                if ((double)arrayWind[i] >= 15 && (double)arrayCloud[i] < 25) //Tweak the values here to recieve different output
                {
                    row[0] = arrayDate[i];
                    row[1] = (double)arrayWind[i];
                    row[2] = (double)arrayCloud[i];
                    row[3] = "Yes, both windy and sunny weather!";
                    dataTableWeather.Rows.Add(row);
                }
                else if ((double)arrayWind[i] >= 15 && (Double)arrayCloud[i] >= 25)
                {
                    row[0] = arrayDate[i];
                    row[1] = (double)arrayWind[i];
                    row[2] = (double)arrayCloud[i];
                    row[3] = "Yes, but only if you primary energy source is wind.";
                    dataTableWeather.Rows.Add(row);
                }
                else if ((double)arrayWind[i] < 15 && (double)arrayCloud[i] < 25)
                {
                    row[0] = arrayDate[i];
                    row[1] = (double)arrayWind[i];
                    row[2] = (double)arrayCloud[i];
                    row[3] = "Yes, but only if your primary energy source is solar.";
                    dataTableWeather.Rows.Add(row);
                }
                else
                {
                    row["Date"] = arrayDate[i];
                    row["Wind Velocity (km/h)"] = (double)arrayWind[i];
                    row["Cloud Coverage (%)"] = (double)arrayCloud[i];
                    row["Charge?"] = "No, it is cloudy and not very windy.";
                    dataTableWeather.Rows.Add(row);
                }
                
                //if ((double)arrayCloud[i] < 25) //Tweak the values here to recieve different output
                //{
                //    Console.WriteLine("Sunny on the date: " + arrayDate[i]);
                //    Console.WriteLine("The cloud coverage is: " + (double)arrayCloud[i] + "%");
                //    Console.WriteLine("-------------------------------");

                //    row["Date"] = arrayDate[i];
                //    row["Wind Velocity"] = (double)arrayWind[i];
                //    row["Cloud Coverage"] = (double)(arrayCloud[i]);
                //}
            }
            return dataTableWeather;
        }
    }
}
