using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class cronometro
    {
        public static void Main(string[] args)
        {
            for (int m = 0; m < 59; m++)
            {
                for (int s= 0; s < 59; s++)
                {
                  
                        Thread.Sleep(1000);
                        Console.WriteLine($"{m}:{s}");
                    
                }
            }
        }
    }
}
