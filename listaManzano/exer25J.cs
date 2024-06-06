using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25J
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a cotação do dólar do dia:");
            float cotacao = float.Parse(Console.ReadLine());
            Console.WriteLine("digite a quantidade de dólares que você tem:");
            float dolares = float.Parse(Console.ReadLine());

            float reais = dolares * cotacao;

            Console.WriteLine("você tem r$" + reais);
        }
    }
}
