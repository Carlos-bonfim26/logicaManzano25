using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25F
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um valor inteiro:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite um valor real:");
            float b = float.Parse(Console.ReadLine());

            float c = b;
            b = a;
            a = Convert.ToInt32(b);

            Console.WriteLine("valor a:" + a + "valor b:");
        }
    }
}
