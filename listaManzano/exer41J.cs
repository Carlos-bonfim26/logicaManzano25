using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41J
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0 && n < 10)
            {
                Console.WriteLine("está na faixa permitida");
            }
            else
            {
                Console.WriteLine("não está na faixa permitida");
            }
        }
    }
}
