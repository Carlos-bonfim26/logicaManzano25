using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41C
    {
        public static void Main(string[] args)
        {
            double[] n1 = new double[4];
            double acumulador = 0;
            for(int i = 0; i <4; i++)
            {
                Console.WriteLine("digite a "+ (i + 1)+ "° nota");
                n1[i] = Convert.ToDouble(Console.ReadLine());
                acumulador += n1[i];
            }
            double media = acumulador / 4;
            if ( media >= 5)
            {
                Console.WriteLine("aprovado, sua nota foi: " + media);
            }
            else
            {
                Console.WriteLine("reprovado, sua nota foi: " + media);
            }
        }
    }
}
