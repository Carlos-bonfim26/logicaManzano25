using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer46H
    {
        public static void Main(string[] args)
        {

            int c = 10;
            float f;

            while (c <= 100)
            {
                f = (9f * c + 160f) / 5f;
                Console.WriteLine(c + "°c = " + f + "°f");
                c += 10;
            }
        }
    }
}
