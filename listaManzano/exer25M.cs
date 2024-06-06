using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25M
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro denovo:");
            int n3 = Convert.ToInt32(Console.ReadLine());

            double resultado = n1 + n2 + n3;

            Console.WriteLine(" soma do quadrado dos três valores é: " + Math.Pow(resultado, 2));
        }
    }
}
