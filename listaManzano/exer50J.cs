using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer50J
    {
        public static void Main(string[] args)
        {
            float n, d, res;
            Console.WriteLine("digite um número inteiro:");
            n = float.Parse(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro:");
            d = float.Parse(Console.ReadLine());
            res = n / d;
            Console.WriteLine($"resultado da divisão inteira {Convert.ToInt32(res)}");
        }
    }
}
