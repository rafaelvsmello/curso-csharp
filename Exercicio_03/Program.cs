using System;
using System.Globalization;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codigoProduto = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double valorTotal;

            switch (codigoProduto)
            {
                case 1:
                    valorTotal = quantidade * 4.0;
                    Console.WriteLine($"Total: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 2:
                    valorTotal = quantidade * 4.5;
                    Console.WriteLine($"Total: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 3:
                    valorTotal = quantidade * 5.0;
                    Console.WriteLine($"Total: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 4:
                    valorTotal = quantidade * 2.0;
                    Console.WriteLine($"Total: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 5:
                    valorTotal = quantidade * 1.5;
                    Console.WriteLine($"Total: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                default:
                    throw new NotImplementedException("Produto não existe");
            }
        }
    }
}
