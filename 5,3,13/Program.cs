namespace _5_3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int [5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите элемента массива {0}", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            SortaArray(arr);
          
        }

        private static void SortaArray(int[] arr)
        {
            Console.WriteLine("массив arr");
            for (int i = 0; i < arr.Length; i++)
            {                              
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine();
            int[] arr1 = SortArrayAsc(arr);
            Console.WriteLine("массив по возростанию");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"{arr1[i]}  ");
            }
            Console.WriteLine();
            int[] arr2 = SortArrayDesc(arr);            
          
            Console.WriteLine("массив по убыванию");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]}  ");
            }

        }

        private static int[] SortArrayAsc(int[] res1)
        {
            int temp = 0;
            for (int i = 0; i < res1.Length; i++)
            {
                for (int j = i + 1; j < res1.Length; j++)
                {
                    if (res1[i] > res1[j])
                    {
                        temp = res1[i];
                        res1[i] = res1[j];
                        res1[j] = temp;
                    }
                }
            }
            return res1;
        }

        private static int[] SortArrayDesc(int[] res2)
        {
            int temp = 0;
            for (int i = 0; i < res2.Length; i++)
            {
                for (int j = i + 1; j < res2.Length; j++)
                {
                    if (res2[i] < res2[j])
                    {
                        temp = res2[i];
                        res2[i] = res2[j];
                        res2[j] = temp;
                    }
                }
            }
            return res2;
        }
    }
}