namespace Singleton_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Select Database \n1.MySql\n2.MongoDB\n3.Oracle\n4.Exit");
            //int dbchoice = Convert.ToInt32(Console.ReadLine());

            //DataBaseFactory factory = new DataBaseFactory();
            //Database db = factory.GetDatabase(dbchoice);
            int dbchoice = 0;
            do
            {
                Console.WriteLine("Select Database: \n1.MySQL\n2.MongoDB\n3.Oracle\n4.Exit.");
                dbchoice = Convert.ToInt32(Console.ReadLine());
                if (dbchoice == 1 || dbchoice == 2 || dbchoice == 3)
                {
                    DataBaseFactory factory = new DataBaseFactory();
                    Database db = factory.GetDatabase(dbchoice);
                    int opchoice = 0;
                    do
                    {
                        Console.WriteLine("Select Operation: \n1.Insert\n2.Update\n3.Delete\n4.Exit and get back to main menu.");
                        opchoice = Convert.ToInt32(Console.ReadLine());
                        switch (opchoice)
                        {
                            case 1:
                                db.doInsert();
                                break;
                            case 2:
                                db.doUpdate();
                                break;
                            case 3:
                                db.doDelete();
                                break;
                            case 4:
                                Console.WriteLine("Revert back to main menu");
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    } while (opchoice != 4);
                }
                else if (dbchoice == 4)
                {
                    Console.WriteLine("Thanks for visiting...");
                }
                else
                {
                    Console.WriteLine("Invalid Choice.");
                }

            } while (dbchoice != 4);

        }
    }

    public abstract class Database
    {
        public Logger _logger = null;
        public Database()
        {
            _logger = Logger.GetLogger();
        }
        protected abstract void insert();
        protected abstract void update();
        protected abstract void delete();

        protected abstract string getDatabaseName();

        public void doInsert() 
        {
            insert();
            _logger.log($"Insert from {getDatabaseName()} done.");
        }
        public void doUpdate()
        {
            update();
            _logger.log($"Update from {getDatabaseName()} done.");
        }
        public void doDelete()
        {
            delete();
            _logger.log($"Delete from {getDatabaseName()} done.");
        }
    }

    public class DataBaseFactory
    {
        public Database GetDatabase(int dbchoice) 
        {
            Database db = null;
            switch (dbchoice)
            {
                case 1:
                    db = new MySql();
                    break;
                case 2:
                    db = new Mongodb();
                    break;
                case 3:
                    db = new Oracle();
                    break;

                default:
                    Console.WriteLine("Invalid Server Selected.");
                    break;
            }
            return db;
        }
    }

    public class MySql : Database
    {
        protected override void delete()
        {
            Console.WriteLine("Data deleted via Mysql.");
        }

        protected override string getDatabaseName()
        {
            return "MySql";
        }

        protected override void insert()
        {
            Console.WriteLine("Data inserted via Mysql.");
        }

        protected override void update()
        {
            Console.WriteLine("Data updated via Mysql.");
        }
    }

    public class Mongodb : Database
    {
        protected override void delete()
        {
            Console.WriteLine("Data deleted via Mongodb.");
        }

        protected override string getDatabaseName()
        {
            return "Mongodb";
        }

        protected override void insert()
        {
            Console.WriteLine("Data inserted via Mongodb.");
        }

        protected override void update()
        {
            Console.WriteLine("Data updated via Mongodb.");
        }
    }

    public class Oracle : Database
    {
        protected override void delete()
        {
            Console.WriteLine("Data deleted via Oracle.");
        }

        protected override string getDatabaseName()
        {
            return "Oracle";
        }

        protected override void insert()
        {
            Console.WriteLine("Data inserted via Oracle.");
        }

        protected override void update()
        {
            Console.WriteLine("Data updated via Oracle.");
        }
    }

    public class Logger
    {
        private static Logger _logger = new Logger();

        public Logger() 
        {
            Console.WriteLine("Logger objected created for first time");
        }

        public static Logger GetLogger() 
        {
            return _logger;
        }

        public void log(string message)
        {
            Console.WriteLine("Logged at {0} message : {1}",DateTime.Now.ToString(),message);
        }
    }
}
