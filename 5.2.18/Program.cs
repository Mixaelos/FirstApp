namespace _5._2._18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var array = GetArrayFromConsole();
            var sortarray = SortArray(array);
            PrintArray(sortarray);
          

        }

        private static void PrintArray(int[] sortarray)
        {
            for (int i = 0; i < sortarray.Length; i++)
            {
                Console.WriteLine(sortarray[i]);
            }
        }
    static int[] GetArrayFromConsole(int num = 10)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемента массива {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static int[] SortArray(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;

        }
        

    }
}