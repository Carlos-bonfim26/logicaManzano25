using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41B
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 < 0)
            {
                Console.WriteLine("agora é positivo: " + (n1 * -1));
            }
            else
            {
                Console.WriteLine("agora é positivo: " + n1);
            }
        }
    }
}
