using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseConnection
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection();
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

            var oracleConnection = new OracleConnection();
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();

            var dbCommand = new DbCommand(sqlConnection);

            dbCommand.Execute("add string \"anosh\" to row 12, column 5");


        }
    }
}
