namespace Inheritance
{
    public class DerivedClassDemo:BaseClassDemo
    {
        public void method2() 
        {
            Console.WriteLine("In DerivedClassDemo in method2");
        }

        public override void mult(int a, int b)
        {
            Console.WriteLine("Through derived class into base class mult()");
            base.mult(a, b);
        }

        public new void add(int a, int b) 
        {
            Console.WriteLine("add() with new. in derived class");
            base.add(a, b);
            Console.WriteLine("In add() of Derived class a + b = {0}", a + b);
        }
        
    }
}
