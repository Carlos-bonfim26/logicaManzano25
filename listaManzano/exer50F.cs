using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer50F
    {
        public static void Main(string[] args)
        {
            int n = 0, acumulador = 0, i = -1; 
            do
            {
                i++;
                acumulador += n;
                
                Console.WriteLine("digite um número positivo (quando quiser encerrar o programa digite um número negativo):");
                n = Convert.ToInt32(Console.ReadLine());
               

            } while (n > 0);

            Console.WriteLine($"a somatoria de todos os números é {acumulador}, e a média é de {acumulador/ i}");
        }
    }
}
