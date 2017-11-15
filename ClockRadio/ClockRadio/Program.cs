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
            ClockRadio clockRadio = new ClockRadio("106.9", false);

            clockRadio.DisplayTime();
            clockRadio.DisplayAlarmStatus();     

            clockRadio.SetAlarm();

            clockRadio.DisplayAlarmStatus();
        }
    }
}
