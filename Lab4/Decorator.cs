using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DotNet
{

    public class Decorator
    {
        protected Clock clock;

        public Decorator(Clock cl)
        {
            clock = cl;
        }

        public virtual void GetTime()
        {
            clock.GetTime();
        }
    }

    public class DigitalClockDecorator:Decorator
    {
        public DigitalClockDecorator(DigitalClock digitalClock) : base(digitalClock)
        {

        }

        public override void GetTime()
        {
            base.GetTime();

            bool am = clock.Hours < 12;
            if (am)
            {
                Console.WriteLine($"\nThe time is: {clock.Hours}:{clock.Minutes} am");
            }
            else
            {
                Console.WriteLine($"\nThe time is: {clock.Hours - 12}:{clock.Minutes} pm");
            }
        }

    }

    public class HandClockDecorator : Decorator
    {
        public HandClockDecorator(HandClock handClock) : base(handClock)
        {

        }

        public override void GetTime()
        {
            string[,] clockMatrix = new string[5, 5];
            
            base.GetTime();

            float hAngle = (360 / 12) * ((float)clock.Hours + (float)clock.Minutes/60f) * 0.01745f;
            float mAngle = (360 / 60) * (float)clock.Minutes * 0.01745f;

            int centerX = 2;
            int centerY = 2;


            float xDirection = (float)Math.Sin(hAngle) - 0.01f;
            float yDirection = -(float)Math.Cos(hAngle) - 0.01f;

            //int xPos = centerX + (int)((xDirection < 0? -1: 1)*Math.Ceiling(Math.Abs(xDirection)));
            //int yPos = centerY + (int)((yDirection < 0 ? -1 : 1)*Math.Ceiling(Math.Abs(yDirection)));

            int xPos = centerX + (int)(Math.Round(xDirection));
            int yPos = centerY + (int)(Math.Round(yDirection));

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    clockMatrix[i, j] = " ";
                }
            }

            clockMatrix[centerY, centerX] = "#";
            clockMatrix[yPos, xPos] = "*";

            xDirection = (float)Math.Sin(mAngle) - 0.01f;
            yDirection = -(float)Math.Cos(mAngle) - 0.01f;
            xPos = centerX + (int)(Math.Round(xDirection));
            yPos = centerY + (int)(Math.Round(yDirection));
            clockMatrix[yPos, xPos] = "+";
            xPos = centerX + (int)(Math.Round(xDirection)*2);
            yPos = centerY + (int)(Math.Round(yDirection)*2);
            clockMatrix[yPos, xPos] = "+";

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n     ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(clockMatrix[i, j]);
                }
            }
        }

    }
}
