using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer41L
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("qual é o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("qual o seu sexo, M ou F");
            char sexo;
             sexo =Convert.ToChar(Console.ReadLine());
           
            if (char.ToUpper(sexo) == 'M'){
                Console.WriteLine("prazer sr " + nome);
            } else if (char.ToUpper(sexo) == 'F')
            {
                Console.WriteLine("prazer sra " + nome);
            }
            else
            {
                Console.WriteLine("olá " + nome);
            }
        }
    }
}
