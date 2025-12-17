namespace Factory_And_Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Select Payment Method: \n1.Credit Card\n2.PayPal\n3.UPI");
                int pchoice = Convert.ToInt32(Console.ReadLine());
                PaymentFactory factory = new PaymentFactory();
                Payment payment = factory.getPayment(pchoice);
                payment.MakePayment();
                Console.WriteLine("Do you want continue ? (y/n)");
                string ynchoice = Console.ReadLine();
                if (ynchoice.Equals("n"))
                {
                    break;
                }
            }
            
        }
    }

    public abstract class Payment 
    {
        protected abstract void authenticate();
        protected abstract void process();
        protected abstract void confirm();

        public virtual void MakePayment() 
        {
            authenticate();
            process();
            confirm();
        }

    }

    public abstract class SecurePayment : Payment 
    {
        protected abstract void extraSecurityCheck();

        public override void MakePayment()
        {
            authenticate();
            extraSecurityCheck();
            process();
            confirm();
        }
    }

    public class PaymentFactory
    {
        public Payment getPayment(int pchoice) 
        {
            Payment payment = null;
            switch (pchoice) 
            {
                case 1:
                    payment = new CreditCard();
                    break;
                case 2:
                    payment = new PayPal();
                    break;
                case 3:
                    payment = new UPI();
                    break;
                default:
                    Console.WriteLine("invalid payment selected.");
                    break;
            }
            return payment;
        }
    }

    public class CreditCard : SecurePayment
    {
        protected override void authenticate()
        {
            Console.WriteLine("Credit Card authentication done.");
        }

        protected override void confirm()
        {
            Console.WriteLine("Credit Card Payment Confirmed");
        }

        protected override void extraSecurityCheck()
        {
            Console.WriteLine("Credit Card OTP verified");
        }

        protected override void process()
        {
            Console.WriteLine("Credit Card Payment Proceded");
        }
    }
    public class PayPal : Payment
    {
        protected override void authenticate()
        {
            Console.WriteLine("PayPal account authenticated.");
        }

        protected override void confirm()
        {
            Console.WriteLine("PayPal payment confirmed.");
        }

        protected override void process()
        {
            Console.WriteLine("PayPal payment processed.");
        }
    }
    public class UPI : SecurePayment
    {
        protected override void authenticate()
        {
            Console.WriteLine("UPI ID authenticated.");
        }

        protected override void confirm()
        {
            Console.WriteLine("UPI payment confirmed.");
        }

        protected override void extraSecurityCheck()
        {
            Console.WriteLine("UPI PIN verified.");
        }

        protected override void process()
        {
            Console.WriteLine("UPI payment processed.");
        }
    }

}
