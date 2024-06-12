using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer66B
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um valor inteiro");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($" {n} x {i} = {n * i}");
            }

        }
    }
}
