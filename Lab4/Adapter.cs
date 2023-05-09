using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DotNet
{
        public interface ITarget
        {
            void GetTime();
        }

        // The Adaptee class that needs to be adapted
        public class Adaptee
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Adaptee method called");
            }
        }

        // The Adapter class that adapts the Adaptee to the ITarget interface
        public class HandClockAdapter : HandClock, ITarget
        {
        public HandClockAdapter(int hours, int minutes) : base(hours, minutes)
        {

        }
        public void GetTime()
            {
                GetHandClockTime();
            }
        }
    public class DigitalClockAdapter : DigitalClock, ITarget
    {
        public DigitalClockAdapter(int hours, int minutes) : base(hours, minutes)
        {

        }
        public void GetTime()
        {
            GetDigitalClockTime();
        }
    }

    // The client code that uses the ITarget interface
    public class Client
        {
            private DigitalClockAdapter DigitalClock;
            private HandClockAdapter HandClock;

        public Client(DigitalClockAdapter digitalClock, HandClockAdapter handClock)
            {
                this.DigitalClock = digitalClock;
                this.HandClock = handClock;
            }

            public void GetTimeFromDigitalClock()
            {
                HandClock.GetTime();
            }

        public void GetTimeFromHandClock()
        {
            DigitalClock.GetTime();
        }
        }

   }
