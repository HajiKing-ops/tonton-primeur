using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;
using MySqlConnector;

namespace tp_tonton.Data
{
    internal class Database
    {
        string connectionString = "Server=localhost;Port=3306;Database=stock_fruits_legumes;User ID=root;Password=;";
        public MySqlConnection GetConnection()
        {
            
            return new MySqlConnection(connectionString);


        }
        
       
    }
}
