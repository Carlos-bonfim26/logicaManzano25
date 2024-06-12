using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer46C
    {
        public static void Main(string[] args)
        {
            int i = 1, acumulador = 0;

            while(i <= 150)
            {
                acumulador += i;
                i++;
            }
            Console.WriteLine(acumulador);
        }
    }
}
