using System;
using System.Collections;
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
        private double electricityPrice;
        private DateTime date;
        private string insertedDateValue;
        private double totalWeekPrice;
        private double averagePrice;
        ArrayList priceList = new ArrayList();

        public void GetElectricityPrice() {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                insertedDateValue = "'2022/01/01'";
                DateTime date1 = DateTime.Parse("2022/01/01");
                DateTime date2 = date1.AddDays(6);
                Console.WriteLine(date2.ToString("yyyy-MM-dd"));

                string sqlQuery = "SELECT Date, SE1 FROM ElectricityPrices WHERE Date between " + "'" + date1.ToString("yyyy-MM-dd") + "'" + " and " + "'" + date2.ToString("yyyy-MM-dd") + "'";
                //command.CommandText = "SELECT Date, SE1 FROM ElectricityPrices\r\nWHERE Date = '2022/01/01'";
                Console.WriteLine(sqlQuery);
                command.CommandText = sqlQuery;
                command.Connection= connection;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    date = reader.GetDateTime(0);
                    electricityPrice= reader.GetDouble(1);
                    Console.WriteLine(electricityPrice);
                    Console.WriteLine(date);
                    totalWeekPrice = totalWeekPrice + electricityPrice;
                    averagePrice = totalWeekPrice / 7;
                    priceList.Add(electricityPrice);

                }
                Console.WriteLine("Snittpris: " + averagePrice + "kr");
                Console.WriteLine(priceList[2]);
                
                foreach (double elPris in priceList)
                {
                    if(elPris < averagePrice)
                    {
                        Console.WriteLine(elPris);
                    }
                }

            }

        }
    }
}
