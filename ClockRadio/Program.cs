using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockRadio MyClock = new ClockRadio();
            bool exitConsole = false;
            while (exitConsole != true)
            {

             
                Console.WriteLine("The current time is: " + MyClock.GetTime());
                Console.WriteLine("The current station is set to: " + MyClock.GetStation());
                Console.WriteLine("The alarm is set to: " + MyClock.GetAlarmTime());

                Console.WriteLine("Enter T - update time, S - update station, A - set Alarm, H - toggle Alarm, Q - Quit:");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "T":
                        Console.WriteLine("Enter a new Time: ");
                        userInput = Console.ReadLine();
                        MyClock.SetTime(userInput);
                        break;
                    case "S":
                        Console.WriteLine("Enter a new Station");
                        userInput = Console.ReadLine();
                        MyClock.SetStation(userInput);
                        break;
                    case "A":
                        Console.WriteLine("Enter a new alarm time: ");
                        userInput = Console.ReadLine();
                        MyClock.SetAlarmTime(userInput);
                        break;
                    case "H":
                        MyClock.ToggleAlarm();
                        break;
                    case "Q":
                        exitConsole = true;
                        break;
                }

            }
        }
    }

   
}
