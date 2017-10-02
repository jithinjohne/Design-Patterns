using System;
using Abstract_Factory;
using Adapter;
using Bridge;
using Builder;
using ChainOfResponsibility;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactory();
            //Adapter();
            //Bridge();
            //Builder();
            ChainOfResponsibility();
        }

        private static void ChainOfResponsibility()
        {
            var _1rupeeHandler = new _1RupeeHandler(null);
            var _10rupeeHandler = new _10RupeeHandler(_1rupeeHandler);
            var _20rupeeHandler = new _20RupeeHandler(_10rupeeHandler);
            var _50rupeeHandler = new _50RupeeHanlder(_20rupeeHandler);
            var _100rupeeHandler = new _100RupeeHandler(_50rupeeHandler);

            Console.WriteLine("Disposing 583.......");
            _100rupeeHandler.Handle(583);

            Console.WriteLine($"{Environment.NewLine}Disposing 255....");
            _100rupeeHandler.Handle(255);
        }

        private static void Builder()
        {
            var engineer = new Engineer();
            Console.WriteLine("****** Creating household robot *******");
            engineer.CreateRobot(new HouseholdRobotBuilder());
            Console.WriteLine($"{Environment.NewLine}****** Creating military robot *******");
            engineer.CreateRobot(new MilitaryRobotBuilder());
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
