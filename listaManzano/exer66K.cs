using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer66K
    {
        public static void Main(string[] args)
        {
            int ft1, ft2;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    ft1 = 1;
                    for (ft2 = 1; ft2 <= i; ft2++)
                    {
                        ft1 += ft2;
                    }
                    Console.WriteLine($"o fatorial de {i} é igual a de {ft1 - 1}");
                }
                
            }
        }
    }
}
