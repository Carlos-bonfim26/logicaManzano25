using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41I
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("neutro");
            }
            else if(n % 2 == 0)
            {
                Console.WriteLine(n + " é par");
            }
            else
            {
                Console.WriteLine(n + " é ímpar");
            }
        }
    }
}
