using System;

namespace FactoryMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer)
                .CreateConnector("minhaCS")
                .Connect();

            sqlCn.ExecuteCommand("select * from tabelaSql");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("-----------");
            Console.WriteLine("");


            var oracleCn = DbFactory.Database(DataBase.Oracle)
                .CreateConnector("minhaCS")
                .Connect();

            sqlCn.ExecuteCommand("select * from tabelaOracle");
            sqlCn.Close();


        }
    }
}
