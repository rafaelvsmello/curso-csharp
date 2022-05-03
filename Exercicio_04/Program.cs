using System;
using System.Globalization;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double a, b, c, delta, x1, x2;

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - (4 * a * c);

            if (a <= 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine($"X1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"X2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}");
            }
        }
    }
}