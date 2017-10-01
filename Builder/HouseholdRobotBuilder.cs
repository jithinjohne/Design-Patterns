using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HouseholdRobotBuilder : IRobotBuilder
    {


        public void CreateHands()
        {
            Console.WriteLine("Hands created");
        }

        public void CreateHead()
        {
            Console.WriteLine("Head created");
        }

        public void CreateLegs()
        {
            Console.WriteLine("Legs created");
        }

        public void CreateTorso()
        {
            Console.WriteLine("Torso created");
        }
    }
}
