using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"..\..\log.txt";
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigratorFileLog = new DbMigrator(new FileLogger(path));
            dbMigrator.Migrate();
            dbMigratorFileLog.Migrate();
    }
    }
}
