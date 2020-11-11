using System;

namespace AngleBetweenHourAndMinutesHands
{
    class Program
    {
        static void Main(string[] args)
        {
            FindTheAngleBetweenHourAndMinutesHands(9, 30);
        }

        private static void FindTheAngleBetweenHourAndMinutesHands(int hours, int minutes)
        {
            // Each hour represent an angle of 30 degrees (360 / 12)
            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);

            // Each minute represents an angle of 6 degrees (360 / 60)
            double minuteInDegrees = minutes * 6;

            double diff = Math.Abs(hourInDegrees - minuteInDegrees);

            if (diff > 180)
            {
                diff = 360 - diff;
            }

            Console.WriteLine($"The angle between {hours} hour and {minutes} minute is {diff} degrees");
        }
    }
}
