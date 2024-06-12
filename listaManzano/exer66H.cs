using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer66H
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o expoente:");
            int e = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < e ; i++)
            {
                n *= n;
            }
            Console.WriteLine(n);
        }
    }
}
