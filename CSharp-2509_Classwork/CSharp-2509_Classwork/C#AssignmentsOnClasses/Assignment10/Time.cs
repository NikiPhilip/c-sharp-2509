
//Create a Time class with overloaded methods to set the time. Implement 
//methods to set the time using hours and minutes, and another method to set the time using 
//seconds. 

using System;

namespace Assignment10
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;


        public void SetTime(int hours, int minutes)
        {
            if (hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60)
            {
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = 0;
            }
            else
            {
                Console.WriteLine("Invalid hours or minutes");
            }
        }

        public void SetTime(int seconds)
        {
            if (seconds >= 0 && seconds < 86400)
            {
                this.hours = seconds / 3600;
                this.minutes = (seconds % 3600) / 60;
                this.seconds = seconds % 60;
            }
            else
            {
                Console.WriteLine("Invalid seconds. ");
            }
        }
        public void DisplayTime()
        {
            Console.WriteLine($"Time: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }

}

