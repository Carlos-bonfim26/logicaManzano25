using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41H
    {
        public static void Main(string[] args)
        {
            double[] n = new double[5];
         double maior = -100000000000, menor = 10000000000000;
            for(int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("digite um número");
                n[i] = Convert.ToDouble(Console.ReadLine());
                if (n[i] > maior)
                {
                    maior = n[i];
                }

                if (n[i] < menor)
                {
                    menor = n[i];
                }
                            
            }
            Console.WriteLine(maior + " é o maior");
            Console.WriteLine(menor + " é o menor");
        }
    }
}
