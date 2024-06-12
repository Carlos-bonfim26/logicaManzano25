using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer66J
    {
        public static void Main(string[] args)
        {
            for (int c = 10; c < 101; c++) 
            {
               float f = (9f * c + 160f) / 5f;

                Console.WriteLine($" {c}°c = {f}°f");
            }
        }
    }
}
