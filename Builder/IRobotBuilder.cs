﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IRobotBuilder
    {
        void CreateHead();
        void CreateTorso();
        void CreateHands();
        void CreateLegs();
    }
}