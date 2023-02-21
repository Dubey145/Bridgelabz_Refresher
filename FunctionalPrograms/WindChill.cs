﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class WindChill
    {
        public void windchill(double t, double v)
        {
            double w = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("The Wind Chill is: " + w);
        }
    }
}
