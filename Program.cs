using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite a medida em Celsius: ");
            Console.ResetColor();
            string celsiusDigitado = Console.ReadLine();
            double celsius = Convert.ToDouble(celsiusDigitado);
            double fireraid = celsius * 1.8 + 32;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{celsius}°C ");
            Console.ResetColor();
            Console.Write("equivalem a ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{fireraid}°F");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
