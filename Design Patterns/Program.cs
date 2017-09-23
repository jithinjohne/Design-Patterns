using System;
using Abstract_Factory;
using Adapter;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory();
            Adapter();
        }

        private static void Adapter()
        {
            var licensePlateLookup = new LicensePlateLookup();
            Console.WriteLine(licensePlateLookup.NameForLicensePlateNumber("JB 007"));
        }

        private static void AbstractFactory()
        {
            var appleFactory = new AppleFactory();
            var samsungFactory = new SamsungFactory();

            Console.WriteLine($"Apple Factory phone :{appleFactory.CreatePhone()}");
            Console.WriteLine($"Apple Factory tablet :{appleFactory.CreateTablet()}");
            Console.WriteLine($"Samsung Factory phone :{samsungFactory.CreatePhone()}");
            Console.WriteLine($"Samsung Factory tablet:{samsungFactory.CreateTablet()}");
        }
    }
}
