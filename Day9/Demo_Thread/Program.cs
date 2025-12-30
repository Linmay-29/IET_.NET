namespace Demo_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = Thread.CurrentThread;
            t1.Name = "Main Thread";
            Console.WriteLine(t1.ManagedThreadId);
            Console.WriteLine(t1.Name);
            
            //method1();

            Thread t2 = new Thread(method1) {Name = "M1Thread" };
            t2.Start();
        }

        static void method1() 
        {
            Console.WriteLine("method1 started using therad {0}",Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++) 
            {
                Console.WriteLine("using thread {0} : {1}",Thread.CurrentThread.Name,i);
            }
            Console.WriteLine("method1 ended using therad {0}", Thread.CurrentThread.Name);
        }
    }
}
