using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer74A
    {
        public static void Main(string[] args)
        {
            string[] lista = new string[10];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("digite algo para sua lista:");
                lista[i] = Console.ReadLine();
            }
            foreach (string item in lista)
            {
                Console.WriteLine("- " + item.ToUpper());
            }
        }
    }
}
