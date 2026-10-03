using System;
using System.Threading;

namespace database
{
    public class DbCommand
    {
        DbConnection connection;
        public DbCommand(DbConnection connection)
        {
            this.connection = connection;
        }

        public void Execute(string instruction)
        {
            // open the connection
            connection.OpenConnection();
            // run the instruction
            Console.WriteLine("executing command... \n" + instruction + "\n");
            Thread.Sleep(500);
            Console.WriteLine("executed!");
            // close connection
            connection.CloseConnection();
        }
    }
}