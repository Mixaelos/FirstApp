namespace _5._3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

           var arr = new int[] { 1, 2, 3 };
            var data = 5;
           BigDataOperation(arr, data);

           Console.WriteLine(arr[0]);

            

            static void BigDataOperation( int[] arr, int data)
            {
                arr[0] = 4;
            }

        }
    }
    
}