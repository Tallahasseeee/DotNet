using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DotNet
{
    public class HandClock:Clock
    {
        public HandClock(int hours, int minutes) : base(hours, minutes)
        {

        }
        public override void GetTime()
        {
            bool am;
            if(Hours < 12)
            {
                am = true;
            }
            else
            {
                am = false;
            }
            int hours = Hours % 12;
            if (hours == 0)
                hours = 12;

            else if (am)
            {
                Console.WriteLine($"\nThe time is: {hours} hours {Minutes} minutes am");
            }
            else
            {
                Console.WriteLine($"\nThe time is: {hours} hours {Minutes} minutes pm");
            }

        }
    }
}
