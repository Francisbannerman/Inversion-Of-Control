using System;

namespace InversionOfControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySQLDatabBase db = new MySQLDatabBase();
            MyOracleDatabase db2 = new MyOracleDatabase();
            MyPostGres db3 = new MyPostGres();

            User user1 = new User(db);
            User user2 = new User(db2);
            User user3 = new User(db3);

            user1.Addon();
            user2.Addon();
            user3.Addon();

            Console.ReadKey();
        }
    }
    public interface IDatabase
    {
        public void Add();
    }



    public class MySQLDatabBase : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("My SQL Database has been added");
        }
    }

    public class MyOracleDatabase : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("My Oracle Database has been added");
        }
    }

    public class MyPostGres : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("My PostGress Database has been added");
        }
    }


    public class User
    {
        IDatabase Database;

        public User(IDatabase database)
        {
            this.Database = database;
        }

        public void Addon()
        {
            Database.Add();
        }
    }
}
