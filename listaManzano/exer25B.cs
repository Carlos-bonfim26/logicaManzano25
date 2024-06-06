using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer25B
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a temperatura em fahrenheit:");
            double f = Convert.ToDouble(Console.ReadLine());

            double c;
            c = (f - 32.0) * (5.0 / 9.0);

            Console.WriteLine(f+"°f = "+ c + "°c");
        }
    }
}
