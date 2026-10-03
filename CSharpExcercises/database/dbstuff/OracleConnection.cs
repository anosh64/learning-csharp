using System;

namespace database
{
    public class OracleConnection : DbConnection
    {
        public override void OpenConnection()
        {
            Console.WriteLine("connected to oracle db!");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("closed connection!");
        }
    }
}