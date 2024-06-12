using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer46J
    {
        public static void Main(string[] args)
        {
            int i = 50, acumulador = 0;
            while (i <= 70)
            {
                if (i % 2 == 0)
                {
                    acumulador += i;
                }
                i++;
            }
            Console.WriteLine("soma: " + acumulador);
            Console.WriteLine("média: " + acumulador / 11);
        }
    }
}
