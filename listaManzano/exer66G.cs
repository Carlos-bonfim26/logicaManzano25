using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer66G
    {
        public static void Main(string[] args)
        {
            int acumulador = 1;

            Console.WriteLine(3 + "^" + 0 + " = " + 1);
            for (int i = 1; i <= 15; i++)
            {
                acumulador *= 3;
                Console.WriteLine(3 + "^" + i + " = " + acumulador);

            }
        }
    }
}
