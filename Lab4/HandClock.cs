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
        public void GetHandClockTime()
        {
            /*bool am;
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
            }*/
            string[,] clockMatrix = new string[5, 5];


            float hAngle = (360 / 12) * ((float)Hours + (float)Minutes / 60f) * 0.01745f;
            float mAngle = (360 / 60) * (float)Minutes * 0.01745f;

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
            xPos = centerX + (int)(Math.Round(xDirection) * 2);
            yPos = centerY + (int)(Math.Round(yDirection) * 2);
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
