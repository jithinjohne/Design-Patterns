using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MilitaryRobotBuilder : IRobotBuilder
    {
        public void CreateHands()
        {
            Console.WriteLine("Military grade hands crated");
        }

        public void CreateHead()
        {
            Console.WriteLine("Head with advanced vision created");
        }

        public void CreateLegs()
        {
            Console.WriteLine("Legs with navigation created");
        }

        public void CreateTorso()
        {
            Console.WriteLine("Torso created");
        }
    }
}
