namespace _5._5._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите число");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите степень");
            byte y = byte.Parse(Console.ReadLine());

            Console.WriteLine(PowerUp(x,y));
        }

        static int PowerUp(int N, byte pow)
        {


            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                    return N * PowerUp(N,--pow);
                
            }
        }
    }
}