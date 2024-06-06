using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25H
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o comprimento da caixa:");
            float comprimento = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o largura da caixa:");
            float largura = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o altura da caixa:");
            float altura = float.Parse(Console.ReadLine());

            float volume = comprimento * largura * altura;

            Console.WriteLine("o volume da caixa é "+ volume );
        }
    }
}
