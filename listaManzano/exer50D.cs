using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer50D
    {
        public static void Main(string[] args)
        {
            int i = 1;
            long  grao = 1, acumulador = 0;

            do
            {
                acumulador += grao;
                Console.WriteLine($"{i}° tabuleiro tem {acumulador}grãos");
                grao *= 2;
                i++;
            } while (i <=64);
        }
    }
}
