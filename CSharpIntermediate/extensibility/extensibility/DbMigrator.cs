using System;
using System.Threading;

namespace extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;
        Random rnd = new Random();
        public DbMigrator(ILogger logger) // injection of the interface
        {                                 // this is extensible and also probably polymorphism but idk about that
            _logger = logger;            // extensibility is super powerful and uses interfaces. this greatly loosens coupling.
        }
        public void Migrate()
        {
            var randomnumber = rnd.Next(1, 46); // generaters a number between 1 and 46

            if (randomnumber == 2)
            {
                _logger.LogInfo($"migration started at {DateTime.Now}");
                Thread.Sleep(800);
                // details of migrating the database
                _logger.LogError($"migration failed! failed at {DateTime.Now}. error could not access DB!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                _logger.LogInfo($"migration started at {DateTime.Now}");
                Thread.Sleep(150);
                // details of migrating the database
                Thread.Sleep(150);
                _logger.LogSuccess($"migration finished at {DateTime.Now}");
            }
        }
    }
}