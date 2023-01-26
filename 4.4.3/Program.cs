using System.Xml.Linq;

namespace _4._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Mikhail", 26);
            Console.WriteLine(name, age);
            Console.Write("повторите ввод имени: ");
            var name1 = Console.ReadLine();
            Console.Write("повторите ввод возраста: ");
            var age1 = Console.ReadLine();
            if (name1 == name && age == age1)
                Console.WriteLine("Верно");
            else 
                Console.WriteLine("не верно");


        }
    }
}