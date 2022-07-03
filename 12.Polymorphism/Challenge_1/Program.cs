using System;

namespace Challenge_1
{
    public abstract class DbConnection
    {
        private string _connectionString;
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string cString, string by)
        {
            if (string.IsNullOrWhiteSpace(cString))
                throw new NullReferenceException($"Passed a null value by {by}, It can't be acceptable");
            _connectionString = cString;
        }
        public abstract void Open();
        public abstract void Close();
    }

    public class SqlConnection : DbConnection
    {
        private int _conCounter;
        public SqlConnection(string d_cString) : base(d_cString, "SQL DB Connection")
        {
            _conCounter = 0;
        }
        public override void Open()
        {
            _conCounter++;
            Console.WriteLine("SQL Database Opens");
        }
        public override void Close()
        {
            if (_conCounter <= 0)
                throw new Exception("There's no SQL connection opens at the moment, Open first.");

            _conCounter--;
            Console.WriteLine("SQL Database Closes.");
        }
        public int Connections() => _conCounter;
    }

    public class OracleConnection : DbConnection
    {
        private int _conCounter;
        public OracleConnection(string d_cString) : base(d_cString, "Oracle DB Connection")
        {
            _conCounter = 0;
        }
        public override void Open()
        {
            _conCounter++;
            Console.WriteLine("Oracle Database Opens.");
        }
        public override void Close()
        {
            if (_conCounter <= 0)
                throw new Exception("There's no Oracle connection opens at the moment, Open first.");

            _conCounter--;
            Console.WriteLine("Oracle Database Closes.");
        }
        public int Connections() => _conCounter;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("dbname=");
            // sql.Close();
            sql.Open();
            Console.WriteLine($"No. of SQL connections are: {sql.Connections()}");
            sql.Close();

            var ocl = new OracleConnection("dbname=");
            // ocl.Close();
            ocl.Open();
            Console.WriteLine($"No. of Oracle connections are: {ocl.Connections()}");
            ocl.Close();
        }
    }
}
