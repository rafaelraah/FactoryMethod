using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{

    //Concrete Product

    public class SqlServerConnector : DbConnector
    {
       
       public SqlServerConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco Sql Server...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }

    }
}
