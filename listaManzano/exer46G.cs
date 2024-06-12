using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer46G
    {
        public static void Main(string[] args)
        {
            int n1 = 1, n2 = 0, fibo, i = 0;

            while(i < 15)
            {
                fibo = n1 + n2;
                n1 = n2;
                n2 = fibo;
                i++;
                Console.WriteLine(fibo);
            }

        }
    }
}
