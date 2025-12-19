namespace Demo_Delegates
{
    public delegate int AddDelegate(int x,int u);
    public delegate int SqurDelegate(int x);

    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cmath = new CMath();  
            AddDelegate addDelg = new AddDelegate(cmath.Add);

        }
    }
    public class CMath 
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Square(int x)
        {
            return x * x;
        }
    }
}
