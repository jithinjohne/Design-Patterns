using System;
using Abstract_Factory;
using Adapter;
using Bridge;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactory();
            //Adapter();
            Bridge();
        }

        private static void Bridge()
        {
            var song = new Song("jimikki kammal", "Velipadinte pusthakam song", "Photo is here ***** ");
            var movie = new Movie("Velipadinte pusthakam", "Mohanlal and Lal jose for the first time together", "Photo ***** ");
            var longView = new LongView();
            Console.WriteLine("Displaying on a long view");
            longView.DisplayOnMonitor(song, movie);

            var shortView = new ShortView();
            Console.WriteLine("Displaying on a short view");
            shortView.DisplayOnMonitor(song, movie);

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
