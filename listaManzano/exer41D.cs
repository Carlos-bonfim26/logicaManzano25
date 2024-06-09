using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41D
    {
        public static void Main(string[] args)
        {
            double[] nota = new double[4];
            double acumulador = 0;
            double media;
            double exame;
            for(int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine("digite a "+ (i+1)+ "° nota do aluno:");
                nota[i] = Convert.ToDouble(Console.ReadLine());
                acumulador += nota[i];
            }
            media = acumulador / nota.Length;
            if(media >= 7)
            {
                Console.WriteLine(media + " de média, parabéns você foi aprovado!");
            } else
            {
                Console.WriteLine("digite a nota do exame final:");
                exame = Convert.ToDouble(Console.ReadLine());
                acumulador += exame;
                media = acumulador /( nota.Length + 1);
                if (media >= 5)
                {
                    Console.WriteLine(media + " de média, aprovado por exame");
                }
                else
                {
                    Console.WriteLine(media + " de média, reprovado");
                }
            }
        }
    }
}
