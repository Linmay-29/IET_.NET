namespace Demo_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.SId = 10;
            Console.WriteLine($"student ID : {stud.SId}");
            
            Console.WriteLine($"student Name : {stud.SName}");
        }
    }

    public class Student
    {
        private int _SId;
        private string _SName;
        private int _Marks;

        public int SId
        {
            set { _SId = value; }
            get { return _SId; }
        }

        public string SName
        {

            set {
                _SName = value; 
               }
            get {
                if (_SName != null)
                {
                    return _SName;
                }
                return "None"; 
            }
        }

        public int Marks
        {
            set { _Marks = value; }
            get { return _Marks; }
        }
    }
}
