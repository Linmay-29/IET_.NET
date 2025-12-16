namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Acess of Methods Base And Derived Class using DerivedClassObj 
            //BaseClassDemo bobj = new DerivedClassDemo();
            //bobj.method1();

            //DerivedClassDemo dobj = new DerivedClassDemo();
            //dobj.method1();
            //dobj.method2(); 
            #endregion

            BaseClassDemo bobj1 = new DerivedClassDemo();
            bobj1.add(1, 2);
            //bobj1.mult(1,2); //will give error as mult() of base class is virtual
            DerivedClassDemo dobj1 = new DerivedClassDemo();
            dobj1.add(1, 2);
            dobj1.mult(1,2);
        }
    }
}
