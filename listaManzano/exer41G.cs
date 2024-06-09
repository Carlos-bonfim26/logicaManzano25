using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41G
    {
        public static void Main(string[] args)
        {
            double[] n = new double[4];

            for(int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("digite um número inteiro:");
                n[i] = Convert.ToDouble(Console.ReadLine());

                if (n[i] % 2 == 0 && n[i] % 3 == 0)
                {
                    Console.WriteLine(n[i] + " é divisil por 2 e por 3");
                }
            }
        }
    }
}
