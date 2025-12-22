namespace Observer_Pattern
{
    public delegate void MyResultEvent(String str);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your obtained marks : ");
            int m = Convert.ToInt32(Console.ReadLine());    
            Marks mrk = new Marks();    
            Result result = new Result();
            if (m > 40)
            {
                result.resEvent += mrk.pass;
                result.ShowResult($"Congratulations your are passed with {m}");
            }
            else 
            {
                result.resEvent += mrk.fail;
                result.ShowResult($"Congratulations your are failed with {m}");
            }
        }
    }

    public class Marks
    {
        public void pass(string message)
        {
            Console.WriteLine(message);
        }
        public void fail(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class Result
    {
        public event MyResultEvent resEvent;

        public void ShowResult(String message) 
        {
            if (resEvent != null)
                resEvent(message);
        }

    }
}
