using System;

namespace databaseConnection
{
    public class SqlConnection : DBConnection
    {
        public override void OpenConnection()
        {
            Console.WriteLine("connected to SQL database");
        }        
        public override void CloseConnection()
        {
            Console.WriteLine("connection closed!");
        }
    }
    }