using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer46I
    {
        public static void Main(string[] args)
        {
            int n = 0, i = 0, acumulador = 0;
         

            while (i < 10)
            {
                Console.WriteLine("digite um número inteiro:");
                n = Convert.ToInt32(Console.ReadLine());
                acumulador += n;
                i++;
            }
            Console.WriteLine("a média dos valores é: " + acumulador / 10);
        }
    }
}
