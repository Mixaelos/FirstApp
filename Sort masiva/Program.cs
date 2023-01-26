namespace Sort_masiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int x;
            for (int k = 0; k < arr.Length; k++)
            {

                for (int i = k + 1; i < arr.Length; i++)
                {
                    if (arr[k] > arr[i])
                    {
                        x = arr[k];
                        arr[k] = arr[i];
                        arr[i] = x;
                    }
                }

            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }
    }



}