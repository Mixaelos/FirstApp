using System.Security.Cryptography.X509Certificates;

namespace _5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someName = "Edutybz";
            Console.WriteLine(someName);

            GetName(ref someName);

            Console.WriteLine(someName);
        }

        static void GetName( ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }
    }
}