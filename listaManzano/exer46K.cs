using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer46K
    {
        public static void Main(string[] args)
        {
            char continuar = 'S';
            string comodo;
            float largura, comprimento, area;
            while (char.ToUpper(continuar) != 'N')
            {
                Console.WriteLine("qual cômodo você está:");
                comodo = Console.ReadLine();
                Console.WriteLine("qual é a largura:");
                largura = float.Parse(Console.ReadLine());
                Console.WriteLine("qual é o comprimento:");
                comprimento = float.Parse(Console.ReadLine());

                area = comprimento * largura;

                Console.WriteLine("a área do " + comodo + " é de " + area + "m²");

                Console.WriteLine("você quer calcular mais um cômodo? S ou N");
               continuar = Convert.ToChar(Console.ReadLine());
               

            }
            Console.WriteLine("programa encerrado!");
        }
    }
}
