using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exemploAula2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("qual seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("qual sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"olá {nome}, você tem {idade} anos");
        }
    }
}
