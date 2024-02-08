using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperMarket
{
    internal class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-E9AFIFO;Initial Catalog=SuperMarket;Integrated Security=True");

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close ();
            }
        }



    }
}
