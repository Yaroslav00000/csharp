using System.Text;

namespace csharp
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Верхня границя інтервалу: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нижня границя інтервалу: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Числа Фібоначчі в діапазоні від {start} до {end}:");
            int? a = 0;
            int? b = 1;
            for (int i = 0; i < end; i++)
            {
                if (a >= start)
                {
                    Console.WriteLine(a);
                }
                int? c = a + b;
                a = b;
                b = c;
                if (a > end)
                {
                    break;
                }
            }
        }
    }
}
