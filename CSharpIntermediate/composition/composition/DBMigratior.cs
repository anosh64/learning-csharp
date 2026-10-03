namespace composition
{
    public class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger) // composition so cool
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("we are migrating blah blah blah....");
        }
    }
}