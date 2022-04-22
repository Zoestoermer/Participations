using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    internal class Bird
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public bool Gender { get; set; } //0 (false) is female, 1 (true) is male
        private int EggCount { get; set; }

        public Bird()
        {
            Height = 0;
            Weight = 0;
            Gender = false;
            EggCount = 0;
        }

        public void LayEggs(int type)
        {
            Random random = new Random();
            if (type == 1)
            {
                EggCount = random.Next(0,3);
            }
            else if (type == 2)
            {
                EggCount = random.Next(0, 5);
            }
        }

        public int GetEggs(bool isMale)
        {
            if (isMale)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            return EggCount;
        }
    }
}
