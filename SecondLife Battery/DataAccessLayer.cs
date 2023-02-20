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
        }

        public async Task GetWeatherAsync()
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Lund?unitGroup=us&key=QDN24AE8877YDJTTM3MYA7RDS&contentType=json");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode(); // Throw an exception if error

            var body = await response.Content.ReadAsStringAsync();

            dynamic weather = JsonConvert.DeserializeObject(body);

            foreach (var obj in weather.days)
            {
                //string weather_test = obj.tempmax;
                //Console.WriteLine(weather_test);
                string weather_Date = obj.datetime;
                string weather_wind = obj.windspeed;
                string weather_cloudcover = obj.cloudcover;
                Console.WriteLine(weather_cloudcover);


            }

        }
    }
}
