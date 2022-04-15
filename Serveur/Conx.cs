using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur
{
    class Conx
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "bibliodb";
            string username = "root";
            string password = "dexter-_-07";

            return DBConx.GetDBConnection(host, port, database, username, password);
        }
    }
}
