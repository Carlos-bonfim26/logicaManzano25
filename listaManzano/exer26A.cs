using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer26A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro denovo:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro mais uma vez:");
            int n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("o produto p:" + (n1 + n3));
            Console.WriteLine("o produto s:" + (n2 + n4));
        }
    }
}
