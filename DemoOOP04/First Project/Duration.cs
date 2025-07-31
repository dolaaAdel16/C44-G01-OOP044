using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.First_Project
{
    internal class Duration
    {
        public int hours { get;  set; }  
        public int minutes { get;  set; }  
        public int seconds { get;  set; }  
        public Duration(int h, int m, int s)
        {
            int total = h * 3600 + m * 60 + s;
            hours = total / 3600;
            minutes = (total % 3600) / 60;
            seconds = total % 60;
        }

        public Duration(int totalSeconds)
        {
            hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            minutes = totalSeconds / 60;
            seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            string output = "Output: ";
            if (hours > 0) output += "Hours: " + hours + ", ";
            if (minutes > 0 || hours > 0) output += "Minutes :" + minutes + ", ";
            output += "Seconds :" + seconds;
            return output;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() - d2.TotalSeconds());
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.TotalSeconds() - 60);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public int TotalSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    
    }
}
