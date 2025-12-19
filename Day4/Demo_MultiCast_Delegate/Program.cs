namespace Demo_MultiCast_Delegate
{
    public delegate void Multi_Caste_Delegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is Birthday boy comming.(y/n)");
            string bday_boy_arrival = Console.ReadLine();
            BirthdayParty bday = new BirthdayParty();
            Multi_Caste_Delegate handler = bday.planning;
            if (bday_boy_arrival.Equals("y"))
            {
                handler += bday.preparation;
                handler += bday.setup;
                handler += bday.arrival;
                handler += bday.celebration;
                handler += bday.closing;
                handler += bday.postEvent;
                handler -= bday.planCancle;
            }
            else
            {
                handler -= bday.preparation;
                handler -= bday.setup;
                handler -= bday.arrival;
                handler -= bday.celebration;
                handler -= bday.closing;
                handler -= bday.postEvent;
                handler += bday.planCancle;
            }
                handler();
        }
    }
    public class BirthdayParty
    {
        public void planning(){
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
        public void postEvent ()
        {
            Console.WriteLine("Share all photos and videos..");
        }
        public void planCancle()
        {
            Console.WriteLine("Sorry!! Plan cancle");
        }
    }
}
