using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25L
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro denovo:");
            int n3 = Convert.ToInt32(Console.ReadLine());

            double resultaldo = Math.Pow(n1, 2) + Math.Pow(n2, 2) + Math.Pow(n3, 2);

            Console.WriteLine("a soma dos quadrados dos três valores é: " + resultaldo);

        }
    }
}
