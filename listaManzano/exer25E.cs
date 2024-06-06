using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25E
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o valor da conta:");
            float valor = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor da taxa de atraso:");
            float taxa = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o tempo de atraso:");
            float tempo = float.Parse(Console.ReadLine());

            float prestacao = valor + valor * taxa / 100 * tempo;

            Console.WriteLine("o valor da prestação que terá que ser paga é R$" + prestacao);
        }
    }
}
