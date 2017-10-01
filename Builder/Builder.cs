using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// I want to call the builder an Engineer. 
    /// </summary>
    public class Engineer
    {
        public void CreateRobot(IRobotBuilder robotBuilder)
        {
            robotBuilder.CreateHead();
            robotBuilder.CreateHands();
            robotBuilder.CreateTorso();
            robotBuilder.CreateLegs();
        }
    }
}
