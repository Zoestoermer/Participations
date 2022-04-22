using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Birds
{
    internal class Penguin : Bird
    {
        public double SwimDepthMax { get; set; }
        public double UnderwaterMinutes { get; set; }

        public Penguin()
        {
            SwimDepthMax = 0;
            UnderwaterMinutes = 0;
        }

        public double CalculateUnderwater()
        {
            return (Height * Weight) / 1860;
        }


    }
}
