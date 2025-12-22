namespace Demo_Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            stu1.SId = 201;
            stu1.SName = "Linmay Patil";
            stu1.SAddress = "Jalgaon, Maharashtra";

            Student stu2 = new Student();
            stu2.SId = 202;
            stu2.SName = "Bruce Wayne";
            stu2.SAddress = "Gotham City";

            Student stu3 = new Student();
            stu3.SId = 203;
            stu3.SName = "Manish";
            stu3.SAddress = "Jalgaon";

            #region List<T>
            List<Student> students = new List<Student>();
            students.Add(stu1);
            students.Add(stu2);
            students.Add(stu3);

            foreach (Student stu in students)
            {
                Console.WriteLine($"Id: {stu.SId}, Name: {stu.SName}, Address : {stu.SAddress}");
            }
            #endregion

            #region Dictionary<TKey, TValue>
            Dictionary<int, Student> stuDict = new Dictionary<int, Student>();
            stuDict.Add(stu1.SId, stu1);
            stuDict.Add(stu2.SId, stu2);
            stuDict.Add(stu3.SId, stu3);
            foreach (KeyValuePair<int, Student> element in stuDict)
            {
                Student stu = element.Value;
                Console.WriteLine($"Id: {stu.SId}, Name: {stu.SName}, Address : {stu.SAddress}");
            }
            foreach (int key in stuDict.Keys)
            {
                Student stu = stuDict[key] as Student;
                Console.WriteLine($"Key = {key}, Id: {stu.SId}, Name: {stu.SName}, Address : {stu.SAddress}");
            }
            
            #endregion
        }
    }

    public class Student
    {
        private int _SId;
        private string _SName;
        private string _SAddress;

        public string SAddress
        {
            get { return _SAddress; }
            set { _SAddress = value; }
        }

        public string SName
        {
            get { return _SName; }
            set { _SName = value; }
        }
        public int SId
        {
            get { return _SId; }
            set { _SId = value; }
        }
    }
}
