using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DotNet
{
    public class DigitalClock:Clock
    {
        public DigitalClock(int hours, int minutes) : base(hours, minutes)
        {

        }
        public override void GetTime()
        {
            string hchar;
            string mchar;
            if (Hours < 10)
                hchar = "0";
            else
                hchar = "";

            if (Minutes < 10)
                mchar = "0";
            else
                mchar = "";

            Console.WriteLine($"\nThe time is: {hchar}{Hours}:{mchar}{Minutes}");
        }
    }
}
