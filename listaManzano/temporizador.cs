using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class temporizador
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite os minutos: ");
            int t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite os segundos: ");
            int t2 = Convert.ToInt32(Console.ReadLine());
            int s;

            for(int m = t1; m >= 0; m--)
            {
                if (m < 0 && t2 < 0)
                {
                    Console.WriteLine("o tempo acabou");
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    for (s = t2; s > 0; s--)
                    {

                        Thread.Sleep(1000);
                        Console.WriteLine($"{m}:{s}");

                    }
                    t2 = 59;
                }
            }
        }
    }
}
