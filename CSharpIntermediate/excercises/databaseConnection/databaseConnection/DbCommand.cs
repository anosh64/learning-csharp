using System;
using System.Threading;

namespace databaseConnection
{
    public class DbCommand
    {
        private DBConnection connection { get; set; }
        public DbCommand(DBConnection dbConnection)
        {
            this.connection = dbConnection ?? throw new NullReferenceException("database connection type cannot be null!");
        }
        // the connection is the db connection UNLESS it's null then we throw the null reference exception.
        public void Execute(string command)
        {
            connection.OpenConnection();
            Console.WriteLine($"executing command: {command}");
            for (int i = 0; i < 11; i++)
            {
                var dots = new string('.', i);
                Console.Write($"\r{dots}");
                Random rnd = new Random();
                Thread.Sleep(rnd.Next(68, 242));
            }

            Console.WriteLine();
            Console.WriteLine("command executed!");
            connection.CloseConnection();
        }
    }
}