using System;
using System.Threading;

namespace database
{
    public abstract class DbConnection
    {
        private string connectionString {
            get;
            set;
        }

        public DbConnection()
        {
            
        }
        private TimeSpan Timeout { get; set; }
        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString) || string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("connection string cannot be null, empty or whitespace");
            }
            this.connectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
}