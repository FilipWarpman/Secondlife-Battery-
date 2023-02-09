using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace SecondLife_Battery
{
    public class DAL
    {   //Connecting to SQL Server Database.
        private string connectionString = @"Server=secondlife-battery.database.windows.net;Database=SecondLifeBatteryDB;user=SqlAdmin;password=Secondlife16;";

        public void getWeather() {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM ElectricityPrices";
                command.Connection= connection;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    Console.WriteLine(reader.GetValue(1));
                }
            }

    }
    }
}
