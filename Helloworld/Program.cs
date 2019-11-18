using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie = "";
            Message message = new Message();

            while (saisie != "exit")
            {
                Console.WriteLine(message.GetHelloMessage());
                saisie = Console.ReadLine();
            }
        }
    }
}
