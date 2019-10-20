namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger("C:\\Projects\\log.txt"));
            dbMigrator.Migrator();
        }
    }
}
