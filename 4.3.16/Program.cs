namespace _4._3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int count = 0;
            foreach (var x in arr) 
            {
                if (x > 0)
                    count++;
            }
            Console.WriteLine(count);

        }
    }
}