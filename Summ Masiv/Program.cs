namespace Summ_Masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int Sum = 0;

            for (int k = 0; k < arr.Length; k++)
            {
             Sum = Sum + arr[k];
            }   
            Console.WriteLine(Sum);
        }
    }
}