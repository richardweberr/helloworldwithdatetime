using System;

namespace Helloworld
{
    internal class Date : IDate
    {
        public DayOfWeek getDay()
        {
            return DateTime.Now.DayOfWeek;
        }

        public int getHour()
        {
            return DateTime.Now.Hour;
        }
    }
}
