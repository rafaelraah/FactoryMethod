using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{

    //Concrete Creator

    public class SqlFactory : DbFactory
    {
        //Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
