using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin8
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer tim = new Timer { Seconds = 3700 };
            Clock cl = (tim);
            cl.Display();
            Clock cal = new Clock { Hours = 3, Minutes = 10, Seconds = 5 };
            Timer tttr = (Timer)cal;
            Console.WriteLine(tttr.Seconds);

            Console.Read();
            

        }
    }

    class Timer
    {
        public int Seconds { get; set; }

        public static explicit operator Timer(Clock clock)
        {
            int s= clock.Hours * 3600 + clock.Minutes * 60 + clock.Seconds;
            return new Timer { Seconds = s };
        }

        public static implicit operator Clock(Timer timer)
        {
            int h = timer.Seconds / 3600;
            int m = (timer.Seconds - h * 3600) / 60;
            int s = timer.Seconds - m * 60 - h * 3600;
            return new Clock { Hours = h, Minutes = m, Seconds = s };
        }

    }
    
    class Clock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");
        }

    }
}
