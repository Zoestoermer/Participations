using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    internal class Robin : Bird
    {
        public double FlightSpeed { get; set; }
        private double Wingspan { get; set; }

        public Robin()
        {
            FlightSpeed = 0;
        }

        public void CalculateWingspan()
        {
            Wingspan = Height * 1.67; 
        }

    }
}
