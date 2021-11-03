using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{

    //Abstract Product

    public abstract class DbConnector
    {
       
       protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }
       
        protected string ConnectionString { get; set; }
        public abstract Connection Connect();

    }
}
