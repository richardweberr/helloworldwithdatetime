using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();
            Console.WriteLine(message.GetHelloMessage());
        }
    }
}
