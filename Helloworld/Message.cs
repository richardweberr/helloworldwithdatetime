using System;

namespace Helloworld
{
    public class Message
    {
        private int _time1;
        private int _time2;
        private int _time3;
        private IDate _date;
        private IUserName _userName;

        public Message(int time1 = 9, int time2 = 13, int time3 = 18) : this(new UserName(), new Date(), time1 = 9, time2 = 13, time3 = 18)
        {
        }

        internal Message(IUserName userName, IDate date, int time1 = 9, int time2 = 13, int time3 = 18)
        {
            this._userName = userName;
            this._date = date;
            this._time1 = time1;
            this._time2 = time2;
            this._time3 = time3;
        }

        public string GetHelloMessage()
        {
            string msg = "";
            switch (this._date.getDay())
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    if (this._date.getHour() < this._time1)
                    {
                        msg = "Bonsoir, ";
                    }
                    else if ((this._date.getHour() >= this._time1) && (this._date.getHour() < this._time2))
                    {
                        msg = "Bonjour, ";
                    }
                    else if ((this._date.getHour() >= this._time2) && (this._date.getHour() < this._time3))
                    {
                        msg = "Bon après-midi, ";
                    }
                    else if ((this._date.getHour() >= this._time3) && this._date.getDay() != DayOfWeek.Friday)
                    {
                        msg = "Bonsoir, ";
                    }
                    else
                    {
                        msg = "Bon W.-E. ";
                    }
                    break;
                default:
                    msg = "Bon W.-E. ";
                    break;
            }
            return msg + this._userName.GetUserName();
        }
    }
}
