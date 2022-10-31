using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public static class ConnectionProvider
    {
        public static IDbConnection GetDbConnection()
        {
            return new MySqlConnection("Server=localhost;Database=HotelManagementSystem;Uid=root;pwd=;Convert Zero Datetime=True");
        }
    }
}
