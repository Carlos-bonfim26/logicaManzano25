using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer50B
    {
        public static void Main(string[] args)
        {
            int i = 1, acumulador = 0;
            do
            {
                if (i % 2 == 0)
                {
                    acumulador += i;
                }
                i++;
            } while (i < 501);
            Console.WriteLine(acumulador);
        }
    }
}
