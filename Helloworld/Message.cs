using System;

namespace Helloworld
{
    class Message
    {
        private int time1;
        private int time2;
        private int time3;

        public Message(int time1 = 9, int time2 = 13, int time3 = 18)
        {
            this.time1 = time1;
            this.time2 = time2;
            this.time3 = time3;
        }

        public string GetHelloMessage()
        {
            string msg = "";
            int heure = DateTime.Now.Hour;
            string jour = DateTime.Now.DayOfWeek.ToString();
            string userName = Environment.UserName.Replace(".", " ");

            switch (jour)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if ((heure >= this.time1) && (heure < this.time2))
                    {
                        msg = "Bonjour, ";
                    } else if ((heure >= this.time2) && (heure < this.time3))
                    {
                        msg = "Bon après-midi, ";
                    }
                    else if (((heure >= this.time3) && (heure < this.time1)) && jour != "Friday")
                    {
                        msg = "Bonsoir, ";
                    }
                    else
                    {
                        msg = " Bon W.-E. ";
                    }
                    break;
                default:
                    msg = "Bon W.-E. ";
                    break;
            }
            return msg + userName;
        }
    }
}
