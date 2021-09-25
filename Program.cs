using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n==== Celsius para Fahrenheit ====\n");
            Console.ResetColor();

            Console.WriteLine("Digite a temperatura em Celsius\npara converter em Fahrenheit.\n");

            Console.Write("Temperatura em Celsius: ");
            c = Convert.ToDouble(Console.ReadLine());

            f = (c * 1.8) + 32;    

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Conversão ===\n");
            Console.ResetColor();

            Console.WriteLine($"{c}°C equivalem a {f}°F.\n");
        }
    }
}
