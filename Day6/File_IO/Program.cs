namespace File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string demoFilePath = @"C:\Users\IET\Desktop\250845920035\IET_.NET\Day6\File_IO\Files\data.txt";

            #region StreamWriter 

            //FileStream fileStream = null;

            //if (File.Exists(demoFilePath))
            //{
            //    fileStream = new FileStream(demoFilePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fileStream = new FileStream(demoFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            //}

            //StreamWriter writer = new StreamWriter(fileStream);
            //writer.WriteLine(" Linmay Patil");
            //writer.Flush();
            //writer.Close();
            //fileStream.Close();
            //Console.WriteLine("Write operation completed.");
            #endregion

            #region StreamReader
            //FileStream fileStream = null;

            //if (File.Exists(demoFilePath))
            //{
            //    fileStream = new FileStream(demoFilePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist!!");
            //}

            //StreamReader reader = new StreamReader(fileStream);
            //string fileContent = reader.ReadToEnd();
            //reader.Close();
            //fileStream.Close();
            //Console.WriteLine(fileContent);
            #endregion

            Employee employee = new Employee();
            employee.EmployeeId = 101;
            employee.EmployeeName = "Tony Stark";
            employee.EmployeeAddress = "Shivaji Nagar";

            #region StreamWriter 

            FileStream fileStream = null;

            if (File.Exists(demoFilePath))
            {
                fileStream = new FileStream(demoFilePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fileStream = new FileStream(demoFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine(employee);
            writer.Flush();
            writer.Close();
            fileStream.Close();
            Console.WriteLine("Employee data written successfully.");
            #endregion


        }
    }

    public class Employee
    {
        private int _EmployeeId;
        private string _EmployeeName;
        private string _EmployeeAddress;

        public string EmployeeAddress
        {
            get { return _EmployeeAddress; }
            set { _EmployeeAddress = value; }
        }

        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }
        }

        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        public override string? ToString()
        {
            return $"Id = {_EmployeeId}, Name = {_EmployeeName} , Address = {_EmployeeAddress}";
        }
    }
}

