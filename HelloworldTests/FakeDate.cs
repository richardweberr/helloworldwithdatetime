using Helloworld;
using System;

namespace HelloworldTests
{
    internal class FakeDate : IDate
    {
        private DayOfWeek _day;
        private int _hour;

        public FakeDate(DayOfWeek day, int hour)
        {
            this._day = day;
            this._hour = hour;
        }

        public DayOfWeek getDay()
        {
            return this._day;
        }

        public int getHour()
        {
            return this._hour;
        }
    }
}
