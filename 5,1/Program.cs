namespace _5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите возрас с цифрами:");
           var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{name} {age} лет");
            var favcolors = new string[3];
             for (int i = 0;i < 3; i++)
            {
                favcolors[i] = ShowColor();
                Console.WriteLine(favcolors[i]);
            }
             

            
        }
        

        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();
            
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;                   

            }
            return color;
        }

    }
}