namespace _4._3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 2, -8, 48, 231 - 99, -70, -18, 92, 33 };
       int count = 0;
            for (int i =0 ; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                count++;
            }
             Console.WriteLine(count);

         }
    }
}