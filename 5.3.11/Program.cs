namespace _5._3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.WriteLine("введите число num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите число num2");
            num2 = int.Parse(Console.ReadLine());
            num3 = Sum(ref num1, ref num2);
            num3 = Sum(ref num1, ref num2);
            Console.WriteLine($"число num3 = {num3}");
            Console.WriteLine("введите число num4 на которое будет умножаться num3");
            num4 = int.Parse(Console.ReadLine());
            num4 = num3 * num4; 
            Console.WriteLine($"число num4 = {num4}");
            SumNumbers(ref num1, in num2, in num3, num4);
        }


        static void SumNumbers(ref int num1, in int num2, in int num3, int num4)
        {
            Console.WriteLine($"числа num1={num1}, num2={num2}, num3={num3}, num4={num4}");

        }

        private static int Sum(ref int num1, ref int num2)
        {
            int result = num1 + num2;

            return result;
        }
    }
}