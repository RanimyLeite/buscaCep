using System;

namespace buscaCep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Entre com a informações de CEP");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Entre com o seu CEP: ");
            var cep = Console.ReadLine();
            Console.WriteLine();

            var cepInfo = new CepWebScraping();
            _ = cepInfo.GetCepInfo(cep);

            Console.ReadKey();
        }
    }
}
