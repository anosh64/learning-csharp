using System;

namespace database
{
    public class SqlConnection : DbConnection
    {

        public override void OpenConnection()
        {
            Console.WriteLine("connection to sql db opened!");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("connection closed!");
        }
    }
}