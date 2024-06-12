using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exemploAula1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um texto");
            string txt = Console.ReadLine();

            Console.WriteLine("quantidade de letras: " + txt.Length);
            Console.WriteLine("letras maiusculas: " + txt.ToUpper());
            Console.WriteLine("letras  minusculas: " + txt.ToLower());
        }
    }
}
