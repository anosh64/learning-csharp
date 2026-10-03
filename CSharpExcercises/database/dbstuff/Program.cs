using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var sqlDbConnection = new SqlConnection();
            sqlDbConnection.OpenConnection();
            sqlDbConnection.CloseConnection();
            var oracleDbConnection = new OracleConnection();
            oracleDbConnection.OpenConnection();
            oracleDbConnection.CloseConnection();

            var sqlDbCommand = new DbCommand(sqlDbConnection);


            sqlDbCommand.Execute("do some stuff");

        }
    }
}
