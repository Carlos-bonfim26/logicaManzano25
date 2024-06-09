using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("a diferença do maior para menor é de " +( n1 - n2));
            } else if (n1 == n2)
            {
                Console.WriteLine("são iguais");
            } else
            {
                Console.WriteLine("a diferença do maior para menor é de " + (n2 - n1));
            }

        }
    }
}
