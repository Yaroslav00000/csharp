using System.Text;

namespace csharp
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введіть шестизначне число: ");
            string? input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            int reversedNumber = int.Parse(reversedString);
            Console.WriteLine($"Перевернуте число: {reversedNumber}");
        }
    }
}
