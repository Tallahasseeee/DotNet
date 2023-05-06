using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DotNet
{
    public class Clock
    {
        public int Hours;
        public int Minutes;

        public Clock(int hours, int minutes)
        {
            SetTime(hours, minutes);
        }
        public void IncrementHours()
        {
            Hours++;
            if(Hours == 24)
            {
                Hours = 0;
            }
        }
        public void IncrementMinutes()
        {
            Minutes++;
            if(Minutes == 60)
            {
                Minutes = 0;
                IncrementHours();
            }
        }
        public void SetTime(int hours, int minutes)
        {
            if (hours >= 0 && hours <= 24 && minutes >= 0 && minutes <= 60 && (hours * 60 + minutes) < 24 * 60)
            {
                Hours = hours;
                Minutes = minutes;
            }
            else
            {
                Console.WriteLine("Incorrect Time!");
            }
        }

        public virtual void GetTime()
        {

        }
    }
}
