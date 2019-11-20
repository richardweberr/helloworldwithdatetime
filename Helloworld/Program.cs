using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Message message = new Message();

            while (input != "exit")
            {
                Console.WriteLine(message.GetHelloMessage());
                input = Console.ReadLine();
            }
        }
    }
}
