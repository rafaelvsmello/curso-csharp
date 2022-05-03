using System;
using System.Globalization;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peca1, qtdPeca1, peca2, qtdPeca2;
            double valorUnitarioPeca1, valorUnitarioPeca2, valorTotal;
            string[] vet = Console.ReadLine().Split(' ');

            peca1 = int.Parse(vet[0]);
            qtdPeca1 = int.Parse(vet[1]);
            valorUnitarioPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');

            peca2 = int.Parse(vet[0]);
            qtdPeca2 = int.Parse(vet[1]);
            valorUnitarioPeca2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            valorTotal = (valorUnitarioPeca1 * qtdPeca1) + (valorUnitarioPeca2 * qtdPeca2);
            Console.WriteLine($"VALOR A PAGAR: R${valorTotal:F2}");
        }
    }
}
