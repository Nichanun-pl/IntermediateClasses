using System;

namespace Extensibility
{
    public class DbMigrator
    {
        public void Migrator()
        {
            Console.WriteLine("Migrationg started at {0}", DateTime.Now);
            
            //Details of migrating the database
            
            Console.WriteLine("Migrationg finished at {0}", DateTime.Now);
        }
    }
}
