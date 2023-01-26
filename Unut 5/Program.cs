namespace Unut_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            Console.WriteLine("ВВедите Имя пользователя");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];
            for (int i = 0; i < User.Dishes.Length; i++ )
            {
                Console.WriteLine($"ВВедите лбимое блюдо номер {i+1}");
                User.Dishes[i] = Console.ReadLine();
            }
                
        }
    }
}