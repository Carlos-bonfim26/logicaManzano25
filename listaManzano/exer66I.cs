using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer66I
    {
        public static void Main(string[] args)
        {
            int n1 = 1, n2 = 0, fibo;

            for (int i = 0; i < 15; i++)
            {
                fibo = n1 + n2;
                n1 = n2;
                n2 = fibo;
                Console.WriteLine(fibo);
            }

        }
    }
}
