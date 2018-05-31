using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadioProject
{
    class Greetings
    {
        public Greetings()
        {
            Console.WriteLine("Welcome to your alarm clock!\n\n");
            Console.WriteLine("Today is " + DateTime.Now.DayOfWeek);
            Console.WriteLine("\n\nPress Enter to continue\n\n");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
