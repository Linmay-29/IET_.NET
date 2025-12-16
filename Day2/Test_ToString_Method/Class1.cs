using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ToString_Method
{
    internal class Class1
    {
        public int age;
        private string name;

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
