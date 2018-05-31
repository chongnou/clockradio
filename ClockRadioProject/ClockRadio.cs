using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadioProject
{
    class ClockRadio
    {
        public string radioStation;
        public string alarm;
        public bool alarmOn;

        public ClockRadio()
        {
            UpdateTime();
            AlarmSet();
            RadioStation();
            RadioAndAlarm();
        }

        public void UpdateTime()
        {
            Console.WriteLine("Todays date and current time is: \n\n");
            DateTime time = DateTime.Now;
            Console.WriteLine(time);
        }
        
        public void AlarmSet()
        {
            string userInput;

            Console.WriteLine("\n\nWould you like to set an alarm? Enter yes or no: \n\n");
            userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                alarmOn = true;
                Console.WriteLine("\n\n Please enter time to set alarm. \n\n");
                alarm = Console.ReadLine();
                Console.WriteLine("\n\n Alarm is set to " + alarm + "\n\n");
                Console.ReadLine();
            }
            else if (userInput == "no")
            {
                Console.WriteLine("\n\n Alarm is not set.\n\n");
            }
            else
            {
                Console.WriteLine("\n\n Invalid input, please try again.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public void RadioStation()
        {
            string userInput;

            Console.Clear();
            Console.WriteLine("\n\n Would you like to listen to the radio? Enter yes or no: \n\n");
            userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                Console.WriteLine("\n\n Please enter radio station. \n\n");
                radioStation = Console.ReadLine();
                Console.WriteLine("\n\n Now listening to \n\n" + radioStation);
                Console.ReadLine();
            }
            else if (userInput == "no")
            {
                Console.WriteLine("\n\n Goodnight.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\n Invalid input, please try again.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public void RadioAndAlarm()
        {
            Console.Clear();

            if (alarmOn == true)
            {
                Console.WriteLine("\n\n Alarm is set to \n\n" + alarm);
            }
            else
            {
                Console.WriteLine("\n\n Alarm is not set.");
            }

            Console.WriteLine("\n\n Currently listening to \n\n" + radioStation);
            Console.ReadLine();

        }
    }
}
