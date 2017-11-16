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

        public void DisplayStatus()
        {
            Console.WriteLine("Current time:" + currentTime + ". Alarm time:" + alarmTime + ". Radio station:" + radioStation + ".");
        }

        //member methods
        public void ChangeRadioStation()
        {
            Console.WriteLine("Set the radio station:");
            radioStation = Console.ReadLine();
        }
        public void ChangeTime()
        {
            Console.WriteLine("Please enter the new time:");
            currentTime = Console.ReadLine();
        }
        public void DisplayAlarmStatus()
        {
            if (!isAlarmOn)
            {
                Console.WriteLine("The alarm is currenty set to off.");
            }
            else
            {
                Console.WriteLine("The alarm is currently on.");
                Console.WriteLine("The alarm is set to " + alarmTime + ".");
            }
        }
        public void DisplayRadioStation()
        {
            Console.WriteLine("The current radio station is set to " + radioStation + ".");
        }
        public void DisplayTime()
        {
            Console.WriteLine("The current time is " + currentTime + ". The current radio station is " + radioStation + ".");
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
                Console.WriteLine("The alarm is off.");
            }
            else
            {
                Console.WriteLine("The alarm is on now.");
            }
        }
    }
}
