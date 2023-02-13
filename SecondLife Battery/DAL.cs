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
        private double elPris;
        private DateTime datum;
        private string insertedDateValue;
        private double veckansTotalaElpris;
        private double snittpris;
        ArrayList prisLista = new ArrayList();

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
                    datum = reader.GetDateTime(0);
                    elPris = reader.GetDouble(1);
                    Console.WriteLine(elPris);
                    Console.WriteLine(datum);
                    veckansTotalaElpris = veckansTotalaElpris + elPris;
                    snittpris = veckansTotalaElpris / 7;
                    prisLista.Add(elPris);

                }
                Console.WriteLine("Snittpris: " + snittpris + "kr");
                Console.WriteLine(prisLista[2]);
                
                foreach (double elPris in prisLista)
                {
                    if(elPris < snittpris)
                    {
                        Console.WriteLine(elPris);
                    }
                }

            }

        }
    }
}
