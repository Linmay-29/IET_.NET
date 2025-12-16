namespace Inheritance
{
    public class BaseClassDemo
    {
        public void method1() 
        {
            Console.WriteLine("In BaseClass Method1.");
        }
        public void add(int a, int b) 
        {
            Console.WriteLine("In add() of Base class a + b = {0}",a+b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine("In sub() of Base class a - b = {0}", a - b);
        }

        public virtual void mult(int a, int b)
        {
            Console.WriteLine("In mult() of Base class a * b = {0}", a * b);
        }
    }
}
