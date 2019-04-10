using System;

namespace DemoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your name : ");
                var name = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("@echo : " + name);
                    continue;
                }

                break;
            }
        }
    }
}
