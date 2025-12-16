namespace Different_Input_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ReadLine()
            //Console.WriteLine("Input for ReadLine()");
            //string input1 = Console.ReadLine();
            //Console.WriteLine("ReadLine Output(String format) = {0}", input1);
            #endregion

            #region Read()
            //Console.WriteLine("Input for Read()");
            //int input2 = Console.Read();
            //Console.WriteLine("Read() Output(Integer Fromat) = {0}", input2); 
            #endregion

            Console.WriteLine("Input for ReadKry()");
            ConsoleKeyInfo input3 = Console.ReadKey();
            Console.WriteLine("ReadKey() Output(Object of ConsoleKeyInfo) = {0}", input3);
        }
    }
}
