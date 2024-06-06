using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25D
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o tempo da viagem(só o tempo):");
            double tempo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o velocidade média da viagem:");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            double litrosUsados = velocidade * tempo / 12;

            Console.WriteLine("durante a viagem você usou " + litrosUsados + " litros");
        }
    }
}
