namespace _5._2._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r =GetArrayFromConsole();
            ShowArray(r);

           ShowArray(r, true);
        }

        static void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;
            if (IsSort)
            {
                temp = SortArray(array);
            }

            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }

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
    }
}