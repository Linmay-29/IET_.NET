namespace Demo_Event
{
    public delegate void MyDelegateHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is Birthday boy comming.(y/n)");
            string bday_boy_arrival = Console.ReadLine();
            BirthdayParty bday = new BirthdayParty();
            if (bday_boy_arrival.Equals("y"))
            {
                bday.MyEvent += bday.planning;
                bday.MyEvent += bday.preparation;
                bday.MyEvent += bday.setup;
                bday.MyEvent += bday.arrival;
                bday.MyEvent += bday.celebration;
                bday.MyEvent += bday.closing;
                bday.MyEvent += bday.postEvent;
                bday.MyEvent -= bday.planCancle;
            }
            else
            {
                bday.MyEvent -= bday.planning;
                bday.MyEvent -= bday.preparation;
                bday.MyEvent -= bday.setup;
                bday.MyEvent -= bday.arrival;
                bday.MyEvent -= bday.celebration;
                bday.MyEvent -= bday.closing;
                bday.MyEvent -= bday.postEvent;
                bday.MyEvent += bday.planCancle;
            }
                

            bday.StartEvent();
        }
    }

    public class BirthdayParty
    {
        public event MyDelegateHandler MyEvent;

        public void StartEvent() 
        {
            if (MyEvent != null)
                MyEvent();
        }
        public void planning()
        {
            Console.WriteLine("Lets plan the party.");
        }
        public void preparation()
        {
            Console.WriteLine("We should start the preparation.");
        }
        public void setup()
        {
            Console.WriteLine("Check if everything is properly setup.");
        }
        public void arrival()
        {
            Console.WriteLine("Yooo!!! BirthdayBoy has arrived..");
        }
        public void celebration()
        {
            Console.WriteLine("Cut the cake!!!!");
        }
        public void closing()
        {
            Console.WriteLine("Thanks for coming..");
        }
        public void postEvent()
        {
            Console.WriteLine("Share all photos and videos..");
        }
        public void planCancle()
        {
            Console.WriteLine("Sorry!! Plan cancle");
        }
    }
}
