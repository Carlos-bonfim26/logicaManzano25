using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41F
    {
        public static void Main(string[] args)
        {
            double[] n = new double[3];

            for(int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("digite o " + (i + 1) + "° valor");
                n[i] = Convert.ToDouble(Console.ReadLine());
            }

            if (n[0] > n[1] && n[0] > n[2])
            {
                if (n[1] > n[2])
                {
                    Console.WriteLine(n[2] + " "+ n[1]+ " " + n[0]);
               
                }
                else
                {
                  
                    Console.WriteLine(n[1] + " " + n[2] + " " + n[0]);
                }
            }
            else if (n[1] > n[0] && n[1] > n[2])
            {
                if (n[0] > n[2])
                {
             
                    Console.WriteLine(n[2] + " " + n[0] + " " + n[1]);
                }
                else
                {
            
                    Console.WriteLine(n[0] + " " + n[2] + " " + n[1]);
                }
            }
            else if (n[2] > n[0] && n[2] > n[1])
            {
                if (n[0] > n[1])
                {
              
                    Console.WriteLine(n[1] + " " + n[0] + " " + n[2]);
                }
                else
                {
                   
                    Console.WriteLine(n[0] + " " + n[1] + " " + n[2]);
                }
            }
        }
    }
}
