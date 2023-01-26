namespace _5_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите число");
            var x = int.Parse(Console.ReadLine());

            Console.WriteLine (Factorial(x));
        }

        static decimal Factorial(int num)
        {
            

            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }      
        }
    }
}