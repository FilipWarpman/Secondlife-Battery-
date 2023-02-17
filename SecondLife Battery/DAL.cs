using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLife_Battery
{
    public class DAL
    {   //Connecting to SQL Server Database.
        private string connectionString = @"Server=secondlife-battery.database.windows.net;Database=SecondLifeBatteryDB;user=SqlAdmin;password=Secondlife16;";
        private double electricityPrice;
        private DateTime date;
        private DateTime insertedDateValue;
        private double totalWeekPrice;
        private double averagePrice;
        ArrayList lowerThanAveragePrice = new ArrayList();
        ArrayList priceList = new ArrayList();
        ArrayList dateList = new ArrayList();

        public void SetDate(DateTime tempDateValue)
        {
            insertedDateValue = tempDateValue;
        }
        public ArrayList GetElectricityPrice() {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();

                DateTime date2 = insertedDateValue.AddDays(6);
                Console.WriteLine(date2.ToString("yyyy-MM-dd"));
                
                string sqlQuery = "SELECT Date, SE1 FROM ElectricityPrices WHERE Date between " + "'" + insertedDateValue.ToString("yyyy-MM-dd") + "'" + " and " + "'" + date2.ToString("yyyy-MM-dd") + "'";
                Console.WriteLine(sqlQuery);//write out query 
                command.CommandText = sqlQuery;
                command.Connection= connection;

                SqlDataReader reader = command.ExecuteReader();
              
                while (reader.Read())
                {
                    date = reader.GetDateTime(0);//Get the date in column nbr 0
                    electricityPrice= reader.GetDouble(1);//Find electricity price in column nbr 1(SE1)
                    totalWeekPrice = totalWeekPrice + electricityPrice; //Add all prices
                    priceList.Add(electricityPrice);//add to pricelist
                    dateList.Add(date);//Add date to datelist
                }
                averagePrice = totalWeekPrice / priceList.Count;//Calculate the average
                Console.WriteLine(averagePrice);
                
                foreach (Object price in priceList)//loop prices in the list and print each with lower price than average
                {
                    double dayPrice = (double)price;                    
                    if (dayPrice < averagePrice)
                    {
                        int i = priceList.IndexOf(price);
                        DateTime tempDate = (DateTime)dateList[i];
                        Console.WriteLine("Date when price is lower than average is " + tempDate.ToString("yyyy-MM-dd") + " and the price is: " + dayPrice + "kr/MWh.");
                        lowerThanAveragePrice.Add(dayPrice);                         
                    }
                }
                return lowerThanAveragePrice;
            }
        }
        public void ClearData()
        {
            Console.WriteLine(" Längden av lowerThanAveragePrice är så här många element: "+lowerThanAveragePrice.Count);
            lowerThanAveragePrice.Clear();
            priceList.Clear();
            dateList.Clear();
        }
    }
}
