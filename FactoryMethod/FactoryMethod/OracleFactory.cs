using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{

    //Concrete Creator

    public class OracleFactory : DbFactory
    {

        public override DbConnector CreateConnector(string connectionString)
        {
            return new OracleDbConnector(connectionString);
        }

    }
}
