using System;

namespace obj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("как вас зовут?");
            string Name = Console.ReadLine();
            Console.WriteLine("сколько вам лет?");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("У вас есть питомец? (true or false)");
            bool pet = bool.Parse(Console.ReadLine());
            Console.WriteLine("какой у вас размер ноги?");
            double size = double.Parse(Console.ReadLine());
            Console.WriteLine($"как вас зовут?\t {Name}.\nсколько вам лет?\t {age}. \nУ вас есть питомец?\t {pet}. \nкакой у вас размер ноги?\t {size}.");

        }
    }
}
