using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_WPF
{
    class ConnectionToDB
    {
        public MySqlConnection SqlConnet;
        public void Connect()
        {
            SqlConnet = new MySqlConnection("server = 127.0.0.1;" +
                "port=8597;" +
                "username=mysql;" +
                "password=mysql;" +
                "database=oop");
        }
    }
}
