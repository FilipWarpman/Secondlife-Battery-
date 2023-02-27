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
        DataTable dataTable1 = new DataTable();
        DataTable dataTable2 = new DataTable();
        DataTable dataTable3 = new DataTable();
        DataTable dataTable4 = new DataTable();
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
        public DataTable GetElectricityPriceSE1()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                DateTime date2 = insertedDateValue.AddDays(6);

                string sqlQuery = "SELECT Date, SE1 FROM ElectricityPrices WHERE Date between CAST(GETDATE()-365 as Date) and CAST(GETDATE()-359 as Date)";
                command.CommandText = sqlQuery;
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataTable1);
                dataTable1.Columns["SE1"].ColumnName = "Electricity Price";
            }
            return dataTable1;
        }
        public DataTable GetElectricityPriceSE2()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                DateTime date2 = insertedDateValue.AddDays(6);

                string sqlQuery = "SELECT Date, SE2 FROM ElectricityPrices WHERE Date between CAST(GETDATE()-365 as Date) and CAST(GETDATE()-359 as Date)";
                command.CommandText = sqlQuery;
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataTable2);
                dataTable2.Columns["SE2"].ColumnName = "Electricity Price";
            }
            return dataTable2;
        }
        public DataTable GetElectricityPriceSE3()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                DateTime date2 = insertedDateValue.AddDays(6);

                string sqlQuery = "SELECT Date, SE3 FROM ElectricityPrices WHERE Date between CAST(GETDATE()-365 as Date) and CAST(GETDATE()-359 as Date)";
                command.CommandText = sqlQuery;
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataTable3);
                dataTable3.Columns["SE3"].ColumnName = "Electricity Price";
            }
            return dataTable3;
        }
        public DataTable GetElectricityPriceSE4()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                DateTime date2 = insertedDateValue.AddDays(6);

                string sqlQuery = "SELECT Date, SE4 FROM ElectricityPrices WHERE Date between CAST(GETDATE()-365 as Date) and CAST(GETDATE()-359 as Date)";
                command.CommandText = sqlQuery;
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataTable4);
                dataTable4.Columns["SE4"].ColumnName = "Electricity Price";
            }
            return dataTable4;
        }
        public void ClearData()
        {
            //dataTable.Clear();
            //dataTable.Columns.Clear();
        }
        public void ClearWeatherData()
        {
            dataTableWeather.Clear();
            dataTableWeather.Columns.Clear();
        }

        public async Task<DataTable> GetWeatherAsync(string electricityArea)
        {
            string aPIRequest = "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Lund?unitGroup=us&key=QDN24AE8877YDJTTM3MYA7RDS&contentType=json";

            if (electricityArea.Equals("SE1"))
            {
                aPIRequest = "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Lund?unitGroup=us&key=QDN24AE8877YDJTTM3MYA7RDS&contentType=json";
            }
            else if (electricityArea.Equals("SE2"))
            {
                aPIRequest = "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Lund?unitGroup=us&key=QDN24AE8877YDJTTM3MYA7RDS&contentType=json";
            }
            else if (electricityArea.Equals("SE3"))
            {
                aPIRequest = "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Lund?unitGroup=us&key=QDN24AE8877YDJTTM3MYA7RDS&contentType=json";
            }
            
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, aPIRequest);

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
                else if ((double)arrayWind[i] >= 15 && (Double)arrayCloud[i] >= 25) //Tweak the values here to recieve different output
                {
                    row[0] = arrayDate[i];
                    row[1] = (double)arrayWind[i];
                    row[2] = (double)arrayCloud[i];
                    row[3] = "Yes, but only if your primary energy source is wind.";
                    dataTableWeather.Rows.Add(row);
                }
                else if ((double)arrayWind[i] < 15 && (double)arrayCloud[i] < 25) //Tweak the values here to recieve different output
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
            }
            return dataTableWeather;
        }
    }
}
