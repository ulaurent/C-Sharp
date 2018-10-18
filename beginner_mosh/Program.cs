
using CSharpFundamentals.Math;
using System; 

namespace CSharpFundamentals 
{
    // Used when you have a number of related constants
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.setFirstName("Ben");
            firstPerson.setLastName("Laurent");
            firstPerson.introDuce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(2, 3);
            Console.WriteLine(result);

            // Initializing and allocation space for an array of ints

            int [] numbers = new int[4]{0,1,2,3};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i);
            }

            // Shipping method

            var method = ShippingMethod.RegisteredAirMail;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            var methodToString = method.ToString();
            Console.WriteLine(methodToString);

            // Working With Dates 
            var dateTiime = new DateTime(2015, 1, 1);

            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute); 
        }
    }
}
