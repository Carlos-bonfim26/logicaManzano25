using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer46L
    {
        public static void Main(string[] args)
        {
            int n = 0, maior = 0, menor = 1000000000;

            while (n >= 0)
            {
                if (n >= maior)
                {
                    maior = n;
                }
                else if (n <= menor)
                {
                    menor = n;
                }
                Console.WriteLine("digite um número inteiro (caso queira parar o programa digite um número negativo):");
                n = Convert.ToInt32(Console.ReadLine());
                

                
                
            }
            Console.WriteLine("maior: " + maior);
            Console.WriteLine("menor: " + menor);
        }
    }
}
