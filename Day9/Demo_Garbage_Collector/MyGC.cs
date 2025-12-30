using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Garbage_Collector
{
   
    public class MyGC : IDisposable
    {
        public void Greet()
        {
            Console.WriteLine(@"
+--------------------------------------+
|   Greetings from Linmay's machine!   |
|   Have a great coding adventure :)   |
+--------------------------------------+
");
        }
        ~MyGC()
        {
            Console.WriteLine("Distructor is called");
        }

        public void Dispose() 
        {
            Console.WriteLine("Dipose method is called...");
            GC.SuppressFinalize(this);
        }
    }

}
