using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer46F
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o expoente:");
            int expoente = Convert.ToInt32(Console.ReadLine());
            int i = 0, acumulador = 1;
            while (i < expoente)
            {
                acumulador *= n;
                i++;
            }
            Console.WriteLine(n + "^" + expoente + " = " + acumulador);
        }
    }
}
