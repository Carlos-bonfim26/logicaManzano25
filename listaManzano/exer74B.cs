using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer74B
    {
        public static void Main(string[] args)
        {
            int[] a = new int[8];
            int[] b = new int[8];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("digite um número inteiro:");
                a[i] = Convert.ToInt32(Console.ReadLine());

                b[i] = a[i] * 3;
            }
            for(int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"{a[i]} x 3 = {b[i]}");
            }
        }
    }
}
