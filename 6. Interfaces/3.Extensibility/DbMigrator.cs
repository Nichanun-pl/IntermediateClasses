using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrator()
        {
            Console.WriteLine("Migrationg started at {0}", DateTime.Now);
            
            //Details of migrating the database
            
            Console.WriteLine("Migrationg finished at {0}", DateTime.Now);
        }
    }
}
