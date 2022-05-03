using System;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string senhaCorreta = "2002";
            string senhaInformada = Console.ReadLine();

            while (!senhaInformada.Equals(senhaCorreta))
            {
                Console.WriteLine("Senha invalida");
                senhaInformada = Console.ReadLine();
            }

            Console.WriteLine("Acesso permitido");
        }
    }
}
