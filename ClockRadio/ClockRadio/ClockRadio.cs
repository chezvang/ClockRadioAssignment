using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class ClockRadio
    {
        //member variables
        public string currentTime;
        public string radioStation;
        public bool isAlarmOn;
        public string alarmTime;

        //constructor
        public ClockRadio(string radioStation, bool isAlarmOn)
        {
            ChangeTime(); //calls ChangeTime, method already created

            this.radioStation = radioStation;
            this.isAlarmOn = isAlarmOn;
        }

        //member methods
        public void ChangeRadioStation()
        {

        }
        public void ChangeTime()
        {
            Console.WriteLine("Please eneter the new time:");
            currentTime = Console.ReadLing();
        }
        public void DisplayAlarmStatus()
        {
            if (!isAlarmOn)
            {
                Console.WriteLine("The alarm is currenty off.");
            }
            else
            {
                Console.WriteLine("The alarm is currently on.");
                Console.WriteLine("The alarm is set to " + alarmTime + ".");
            }
        }
        public void DisplayRadioStation()
        {

        }
        public void DisplayTime()
        {
            Console.WriteLine("The current time is " + currentTime + ".");
        }
        public void SetAlarm()
        {
            if (!isAlarmOn)
            {
                ToggleAlarm();
            }
            Console.WriteLine("Please enter the new alarm time:");
            alarmTime = Console.ReadLine();
        }
        public void ToggleAlarm()
        {
            isAlarmOn = !isAlarmOn;
            if (isAlarmOn)
            {
                Console.WriteLine("The alarm is on now.");
            }
            else
            {
                Console.WriteLine(("The alarm is off now.");
            }
        }
        

    }
}
