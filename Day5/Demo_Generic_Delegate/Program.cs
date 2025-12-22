namespace Demo_Generic_Delegate
{
   
    public delegate T MyDelegate<T>();

    internal class Program
    {
        static void Main(string[] args)
        {
            Product<string> product = new Product<string>();
            MyDelegate<string> del = new MyDelegate<string>(product.ShowProduct);

            
            string result = del();
            Console.WriteLine(result);
        }
    }

    
    public class Product<T>
    {
        public T ShowProduct()
        {
            Console.WriteLine("Showing Product Details...");
            return (T)(object)"Product: Laptop, Price: $1200";
        }
    }
}

