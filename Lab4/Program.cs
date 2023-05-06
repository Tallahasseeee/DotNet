using System;

namespace Lab4DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalClock digitalClock = new DigitalClock(8,38);
            HandClock handClock = new HandClock(1, 50);
            Decorator digitalClockDecorator = new DigitalClockDecorator(digitalClock);
            Decorator handClockDecorator = new HandClockDecorator(handClock);
            digitalClock.GetTime();
            handClock.GetTime();
            digitalClockDecorator.GetTime();
            handClockDecorator.GetTime();
        }
    }
}
