using System;
using System.Collections.Generic;
using System.Data;
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
        private double elPris;
        private DateTime datum;
        private string insertedDateValue;
<<<<<<< Updated upstream
=======
        private double totalWeekPrice;
        private double averagePrice;
        ArrayList priceList = new ArrayList();
        ArrayList dateList = new ArrayList();
>>>>>>> Stashed changes

        public void GetElectricityPrice() {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                insertedDateValue = "'2022/01/01'";

                string sqlQuery ="SELECT Date, SE1 FROM ElectricityPrices WHERE Date = " + insertedDateValue;
                //command.CommandText = "SELECT Date, SE1 FROM ElectricityPrices\r\nWHERE Date = '2022/01/01'";
                Console.WriteLine(sqlQuery);
                command.CommandText = sqlQuery;
                command.Connection= connection;

                SqlDataReader reader = command.ExecuteReader();
              
                while (reader.Read())
                {
<<<<<<< Updated upstream
                    Console.WriteLine(reader.GetValue(1).GetType());

                    datum = reader.GetDateTime(0);
                    for (int i = 0;i < 7; i++)
                    {
                        datum = datum.AddDays(1);
                        elPris = reader.GetDouble(1);
                        Console.WriteLine(elPris);
                        Console.WriteLine(datum);
=======
                    date = reader.GetDateTime(0);
                    electricityPrice= reader.GetDouble(1);
                    totalWeekPrice = totalWeekPrice + electricityPrice;
                    priceList.Add(electricityPrice);
                    dateList.Add(date);
                }
                averagePrice = totalWeekPrice / priceList.Count;
                
                foreach (Object price in priceList)
                {
                    double dayPrice = (double)price;
                    if (dayPrice < averagePrice)
                    {
                        int i = priceList.IndexOf(price);
                        Console.WriteLine("Date when price is lower than average is " + dateList[i] + " and the price is: " + dayPrice + "kr/MWh.");
>>>>>>> Stashed changes
                    }
                    
                }
            }

    }
    }
}
