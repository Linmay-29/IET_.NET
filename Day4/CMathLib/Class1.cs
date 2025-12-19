namespace CMathLib
{
    public class CMath
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        private int sub(int x, int y)
        {
            return x - y;
        }
        protected int multt(int x, int y)
        { return x * y; }
        internal int div(int x,int y)
            { return x / y; }

        protected internal int squr(int x)
        { return x * x; }
    }

    public class AdvMath : CMath
    {
        public void AdvWrapperMethod() {
            Console.WriteLine("Squr via AdvWrapper method : " + base.squr(2));
            Console.WriteLine("Mult via AdvWrapper method : " + base.multt(2, 2));
            Console.WriteLine("Div via AdvWrapper method : " + base.div(2, 2));
        }
    }


}
