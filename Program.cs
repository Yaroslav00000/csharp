using System.Text;

namespace csharp
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть перше число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число більше за перше:");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
