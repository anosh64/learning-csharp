using System;
using System.Data.Common;
using System.Threading;

namespace databaseConnection
{
    public abstract class DBConnection
    {
        private string ConnectionString { get; }
        public string Connectionstring => ConnectionString;

        private TimeSpan _timeout = TimeSpan.FromSeconds(10);

        public DBConnection()
        {
            
        }
        public DBConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString) || string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("connection string cannot be null, empty or whitespace");
            }

            this.ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
}