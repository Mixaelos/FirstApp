namespace _4._4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.Write("Введите Имя питомца: ");
            Pet.Name = Console.ReadLine();
            Console.Write("Введите вид питомца: ");
            Pet.Type = Console.ReadLine();
            Console.Write("Введите возраст питомца: ");
            Pet.Age = double.Parse(Console.ReadLine());


        }
    }
}