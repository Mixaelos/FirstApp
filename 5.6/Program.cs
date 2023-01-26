using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace _5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string surename, int age, string pet, int color) man;
           
            Console.WriteLine("введите Имя");
            man.name = Console.ReadLine();
            Console.WriteLine("введите Фамилию");
            man.surename = Console.ReadLine();
                Console.WriteLine("введите возраст");
                man.age = int.Parse(Console.ReadLine());
            if (man.age < 1)
            {
                man.age = NumCheck();
            }
            Console.WriteLine("есть ли у вас питомец(ы)?");
            man.pet = Console.ReadLine();

            if (man.pet == "да" || man.pet == "Да")
            {
                PetCheck();
            }
            string[] PetMas = PetCheck();
            Console.WriteLine("Сколько у вас любимых цветов?");
                man.color = int.Parse(Console.ReadLine());
            if (man.color < 1) 
            {
                man.color = NumCheck();
            } 
            string []colorMas = ColorCheck(man.color);
            PrintKor(ref man.name,ref man.surename,ref man.age,ref man.pet,ref man.color, ref PetMas, ref colorMas);
        }

        private static int NumCheck ()
        {
            int num;
            do
            {
                Console.WriteLine("введите число >= 1");
                num = int.Parse(Console.ReadLine());
            }
            while (num < 1);
            return num;


        }
        private static string[] ColorCheck(int color)
        {
            string[] ColorMas = new string[color];
            for (int i = 0; i < ColorMas.Length; i++)
            {
                Console.WriteLine($"Название {i + 1}-го цвета");
                ColorMas[i] = Console.ReadLine();
            }
            return ColorMas;
        }

        private static string[] PetCheck()
        {
            Console.WriteLine("Сколько у вас питомцев?");
            int x = int.Parse(Console.ReadLine());
            if (x < 1)
            {
                x = NumCheck();
            }
            string[] Petname = new string[x];
            for (int i = 0; i < Petname.Length; i++)
            {
                Console.WriteLine($"Как зовут {i + 1}-го питомца?");
                Petname[i] = Console.ReadLine();
            }
            return Petname;
        }
        static void PrintKor(ref string name,ref string surename,ref int age,ref string pet,ref int color, ref string[] PetMas, ref string[] colorMas)
        {
            Console.WriteLine($"Здравтвуйте {surename} {name} вам {age} лет");
            if (pet == "да" || pet == "Да")
            {
                Console.WriteLine($"у вас {PetMas.Length} питомцев");
                for (int i = 0; i < PetMas.Length; i++)
                {
                    Console.WriteLine($"Кличка {i + 1}-го питомца {PetMas[i]}");
                }
            }
            else
            {
                Console.WriteLine("У вас нет питомцев");
            }
            Console.WriteLine($"Вам нравится {color} цвета");
            for (int i = 0; i < colorMas.Length; i++)
            {
                Console.WriteLine($"{i + 1} цвет {colorMas[i]}");
                    }
        }


    }
}