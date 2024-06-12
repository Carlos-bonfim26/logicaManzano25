using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer46A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while(i < 11)
            {
                Console.WriteLine(n + " x " + i + " = " + n * i);
                i++;
            }

        }
    }
}
