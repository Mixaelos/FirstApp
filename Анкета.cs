using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("When is your birthday?");
            var birthday = Console.ReadLine();
            Console.WriteLine($"Hello {name}, you are {age} yaers old and your birthday is at {birthday}!");

        }
    }
}
