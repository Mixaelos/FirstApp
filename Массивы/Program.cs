using System;

class MainClass
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите своё имя");
        var name = Console.ReadLine();
        {
            Console.WriteLine("Ваше имя по буквам: ");

            for (int i =name.Length - 1; i >= 0;i--)
            {
                Console.Write($"{name[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine("Первая буква Имени: {0}", name[0]);
        }
    }

}