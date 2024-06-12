using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer66D
    {
        public static void Main(string[] args)
        {
            int acumulador = 0;
            for(int i = 1; i < 501; i++)
            {
                if (i % 2 == 0)
                {
                    acumulador += i;
                }
               
            
            }
            Console.WriteLine(acumulador);
        }
    }
}
