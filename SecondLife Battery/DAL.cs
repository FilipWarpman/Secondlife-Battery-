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
    {
        private string connectionString = @"Server=localhost;Database=dbAssignment;user=SecondLife;password=andraliv;";

        public void getWeather() {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Employee";
                command.Connection= connection;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    Console.WriteLine(reader.GetString(1));
                }
            }

    }
    }
}
