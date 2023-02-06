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
            
            SqlConnection connection = new SqlConnection(connectionString);

    }
        

    }
}
