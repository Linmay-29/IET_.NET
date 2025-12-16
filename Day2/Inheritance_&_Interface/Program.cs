namespace Inheritance___Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dbchoice = 0;
            do {
                Console.WriteLine("Select Database: \n1.MySQL\n2.MongoDB\n3.Oracle\n4.Exit.");
                dbchoice = Convert.ToInt32(Console.ReadLine());
                if (dbchoice == 1 || dbchoice == 2 || dbchoice == 3)
                {
                    DataBaseFactory fact = new DataBaseFactory();
                    IDatabase db = fact.getDataBase(dbchoice);
                    int opchoice = 0;
                    do
                    {
                        Console.WriteLine("Select Operation: \n1.Insert\n2.Update\n3.Delete\n4.Exit and get back to main menu.");
                        opchoice = Convert.ToInt32(Console.ReadLine());
                        switch (opchoice)
                        {
                            case 1:
                                db.insert();
                                break;
                            case 2:
                                db.update();
                                break;
                            case 3:
                                db.delete();
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
                
            } while (dbchoice!=4);
        }
    }

    public interface IDatabase
    {
        void insert();
        void update();
        void delete();
    }

    public class DataBaseFactory 
    {
        public IDatabase getDataBase(int dbchoice) 
        {
            IDatabase db = null;
            switch (dbchoice) 
            {
                case 1:
                    db = new MySQL();
                    break;
                case 2:
                    db = new MongoDB();
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

    public class MySQL : IDatabase
    {
        void IDatabase.delete()
        {
            Console.WriteLine("Data deleted via MySQL");
        }

        void IDatabase.insert()
        {
            Console.WriteLine("Data inserted via MySQL");
        }

        void IDatabase.update()
        {
            Console.WriteLine("Data updated via MySQL");
        }
    }
    public class MongoDB : IDatabase
    {
        void IDatabase.delete()
        {
            Console.WriteLine("Data deleted via MongoDB");
        }

        void IDatabase.insert()
        {
            Console.WriteLine("Data inserted via MongoDB");
        }

        void IDatabase.update()
        {
            Console.WriteLine("Data updated via MongoDB");
        }
    }
    public class Oracle : IDatabase
    {
        void IDatabase.delete()
    {
        Console.WriteLine("Data deleted via Oracle");
    }

    void IDatabase.insert()
    {
        Console.WriteLine("Data inserted via Oracle");
    }

    void IDatabase.update()
    {
        Console.WriteLine("Data updated via Oracle");
    }
}
}
