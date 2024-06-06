using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25K
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a cotação do dólar do dia:");
            float cotacao = float.Parse(Console.ReadLine());
            Console.WriteLine("digite a quantidade de reais que você tem:");
            float reais = float.Parse(Console.ReadLine());

            float dolares = reais / cotacao;

            Console.WriteLine("você tem $" + dolares);
        }
    }
}
