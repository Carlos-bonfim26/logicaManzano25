using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer26C
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a quantidade de votos do candidato A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a quantidade de votos do candidato B:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a quantidade de votos do candidato C:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a quantidade de votos nulos:");
            double nulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a quantidade de votos brancos:");
            double brancos = Convert.ToDouble(Console.ReadLine());

            double total = a + b + c + nulo + brancos;

            Console.WriteLine("o total de votos foi de: " + total);
            Console.WriteLine("a porcentagem de votos do candidato A foi de :" + (a / total * 100d) + "%");
            Console.WriteLine("a porcentagem de votos do candidato B foi de :" + (b / total * 100d) + "%");
            Console.WriteLine("a porcentagem de votos do candidato C foi de :" + (c / total * 100d) + "%");
            Console.WriteLine("a porcentagem de votos nulos foi de :" + (nulo / total * 100d) + "%");
            Console.WriteLine("a porcentagem de votos brancos foi de :" + (brancos / total * 100d) + "%");
        }

    }
}
