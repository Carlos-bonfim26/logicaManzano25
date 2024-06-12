using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer46E
    {
        public static void Main(string[] args)
        {
            int i = 0 ,acumulador = 1;

            Console.WriteLine(3 + "^" + 0 + " = " + 1);
            while (i < 15){
                acumulador *= 3;
                i++;
                Console.WriteLine(3 + "^" + i + " = "+ acumulador);
               
            }
        }
    }
}
