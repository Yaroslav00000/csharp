using System.Text;

namespace csharp
{
    internal class Program
    {
        static void Main()
        {
            try {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                int[] numbers = new int[5];
                Console.WriteLine("введіть 5 чисел");
                int? sum = 0;
                int product = 1;
                int min = int.MaxValue;
                int max = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    sum += numbers[i];
                    product *= numbers[i];
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
                Console.WriteLine($"Сума чисел:  {sum}");
                Console.WriteLine($"Добуток чисел: {product}");
                Console.WriteLine($"Мінімальне число: {min}");
                Console.WriteLine($"Максимальне число: {max}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Помилка: " + e.Message);
            }
        }
    }
}
