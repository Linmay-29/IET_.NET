namespace Demo_Garbage_Collector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGC gc = new MyGC();
            gc.Greet();
            //gc.Dispose();

            using (MyGC gc2 = new MyGC()) 
            {
                gc2.Greet();
            }
            
            
        }
    }
}
