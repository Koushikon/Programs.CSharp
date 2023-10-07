using Extensibility.Interfaces;
using Extensibility.Models;

namespace Extensibility;

/***
 * For Now we're logging messages inside Console
 * But in future we may want to log the message in a file or database.
 * 
 * How wan we design DbMigration in such a way that its Extensible.
 * It is an Concrete Print to Console class
 */

/*

public class DbMigrator
{
    public void Migrate()
    {
        Console.WriteLine("Migrating started at {0}", DateTime.Now);

        // Details of migrating database

        Console.WriteLine("Migrating finished at {0}", DateTime.Now);
    }
}

*/



public class DbMigrator
{
    private readonly ILogger _logger;

    /***
     * In the Constructor we're specifying the dependencies of DbMigrator class
     * 
     * DbMigrator doesn't care who's the actutal logger (Console, File, Database etc).
     * An instance of any class that implements ILogger can be passed to this constructor.
     * So, there's now coupling between DbMigrator and that concrete class.
     */
    public DbMigrator(ILogger logger)
    {
        _logger = logger;
    }

    public void Migrate()
    {
        _logger.LogInfo($"Migrating started at {DateTime.Now}");

        // Details of migrating database

        _logger.LogInfo($"Migrating finished at {DateTime.Now}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        /***
         * For Console logging:
         */
        //var dbMigrator = new DbMigrator(new ConsoleLogger());


        /***
         * For File logging:
         * 
         * We change the behaviour of our Application by creating a new class and passing that to the constructor.
         * We didn't change any code of DbMigrator class.
         * 
         * And This is called changing the behaviour by extending the application instead of changing the code.
         * In OOP it is called OCP(Open Closed Principle).
         * OCP means Software entities should be Open(ILogger) for extension But closed (DbMigrator) for modification.
         */
        string fullPath = @"D:\log.txt";
        var dbMigrator = new DbMigrator(new FileLogger(fullPath));

        dbMigrator.Migrate();

        Console.ReadKey();
    }
}