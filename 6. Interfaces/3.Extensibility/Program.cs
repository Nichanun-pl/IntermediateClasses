using System;

namespace Extensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

    public class DbMigrator
    {
        public void Migrator()
        {
            Console.WriteLine("Migrationg started at {0}", DateTime.Now);
            
            //Details of migrating the database
            
            Console.WriteLine("Migrationg finished at {0}", DateTime.Now);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
