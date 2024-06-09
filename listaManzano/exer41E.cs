using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41E
    {
        public static void Main(string[] args)
        {
            double[] valores = new double[3];
            double delta, raiz1, raiz2;
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("digite o " + (i + 1) + "° valor");
                valores[i] = Convert.ToDouble(Console.ReadLine());
                if (valores[0] == 0)
                {
                    while (valores[0] == 0)
                    {
                        Console.WriteLine("o primeiro valor tem que ser diferente de zero");
                        valores[0] = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }

            delta = Math.Pow(valores[1], 2) - 4 * valores[0] * valores[2];

            raiz1 = (-valores[1] + Math.Sqrt(delta)) / (2 * valores[0]);
            raiz2 = (-valores[1] - Math.Sqrt(delta)) / (2 * valores[0]);

            Console.WriteLine("valor de delta: " + Math.Round(delta, 2));
            Console.WriteLine("valor da raiz 1: " + Math.Round(raiz1, 2));
            Console.WriteLine("valor de raiz 2: " + Math.Round(raiz2, 2));
        }
    }
}
