using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25G
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro denovo:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro mais uma vez:");
            int n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("adição:");

            Console.WriteLine(n1  + " + " + n2 + " = " + (n1 + n2));
            Console.WriteLine(n1 + " + " + n3 + " = " + (n1 + n3));
            Console.WriteLine(n1 + " + " + n4 + " = " + (n1 + n4));
            Console.WriteLine(n2 + " + " + n3 + " = " + (n2 + n3));
            Console.WriteLine(n2 + " + " + n4 + " = " + (n2 + n4));
            Console.WriteLine(n3 + " + " + n4 + " = " + (n3 + n4));

            Console.WriteLine("multiplição:");
            Console.WriteLine(n1 + " x " + n2 + " = " + (n1 * n2));
            Console.WriteLine(n1 + " x " + n3 + " = " + (n1 * n3));
            Console.WriteLine(n1 + " x " + n4 + " = " + (n1 * n4));
            Console.WriteLine(n2 + " x " + n3 + " = " + (n2 * n3));
            Console.WriteLine(n2 + " x " + n4 + " = " + (n2 * n4));
            Console.WriteLine(n3 + " x " + n4 + " = " + (n3 * n4));
        }
    }
}
