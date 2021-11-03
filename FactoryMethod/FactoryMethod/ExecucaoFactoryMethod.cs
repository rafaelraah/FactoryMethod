using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class ExecucaoFactoryMethod
    {

        public static void Executar()
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer).CreateConnector("MinhaCS").Connect();
            sqlCn.ExecuteCommand("select * from tabelaSQL");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.WriteLine("");

            var oracleCn = DbFactory.Database(DataBase.Oracle).CreateConnector("MinhaCS").Connect();
            oracleCn.ExecuteCommand("select * from tabelaOracle");
            oracleCn.Close();
        }

    }
}
