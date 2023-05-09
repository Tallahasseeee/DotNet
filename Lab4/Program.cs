using System;

namespace Lab4DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            HandClockAdapter handClockAdapter = new HandClockAdapter(9,50);
            DigitalClockAdapter digitalClockAdapter = new DigitalClockAdapter(5,57);
            handClockAdapter.GetTime();
            digitalClockAdapter.GetTime();

            /*DigitalClock digitalClock = new DigitalClock(8,38);
            HandClock handClock = new HandClock(1, 50);
            Decorator digitalClockDecorator = new DigitalClockDecorator(digitalClock);
            Decorator handClockDecorator = new HandClockDecorator(handClock);
            digitalClock.GetTime();
            handClock.GetTime();
            digitalClockDecorator.GetTime();
            handClockDecorator.GetTime();*/
        }
    }
}
