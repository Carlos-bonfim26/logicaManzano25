using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer50E
    {
        public static void Main(string[] args)
        {

            int n, i = 0;
            long ft1, ft2;

            do
            {
                Console.WriteLine("digite um número inteiro:");
                n = Convert.ToInt32(Console.ReadLine());
                ft1 = 1;
               for (ft2 = 1; ft2 <= n; ft2++)
                {
                    ft1 += ft2;
                  
                }
                Console.WriteLine($"o fatorial de {n} é igual a {ft1 - 1}");
                i++;
            } while (i < 15);
            }
        }
    }

