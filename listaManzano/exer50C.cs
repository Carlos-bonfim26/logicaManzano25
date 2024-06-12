using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer50C
    {
        public static void Main(string[] args)
        {
            int i = 0;

            do
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i < 200);
        }
    }
}
