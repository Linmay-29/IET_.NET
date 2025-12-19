using CMathLib;

namespace CMathClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cmath = new CMath();
            Console.WriteLine("Add via CMath obj : "+cmath.add(1, 2)); 
            MyMath myMath = new MyMath();
            myMath.wrapperMethod();
            AdvMath advMath = new AdvMath();
            advMath.AdvWrapperMethod();
        }
    }
    public class MyMath : CMath
    {
        public void wrapperMethod() {
            Console.WriteLine("Squr via wrapper method : "+base.squr(2));
            Console.WriteLine("Mult via wrapper method : "+base.multt(2, 2)) ;
        }
    }
}
