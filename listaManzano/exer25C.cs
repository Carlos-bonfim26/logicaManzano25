using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25C
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("informe o raio da lata:");
            double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe a altura da lata:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(2, raio) * altura;

            Console.WriteLine("o volume da lata é de:" + Math.Round(volume, 2));
        }
    }
}
