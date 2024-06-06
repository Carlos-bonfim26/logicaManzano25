using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a temperatura em celcius");
            float c = float.Parse(Console.ReadLine());

            float f = (9f * c + 160f) / 5f;

            Console.WriteLine(c + "°c = " + f + "°f");
        }
    }
}
