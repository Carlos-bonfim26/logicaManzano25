using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class roleta
    {
        public static void Main(string[] args)
        {
            string[] nome = { "yan", "amaral", "kauan", "oraboni", "Isaac", "freitas", "samanta"
                    , "milena", "leo", "joaldo", "fellype", "ana", "luiza",
                "enzzo", "grazy", "Carlos", "joão ", "jhony dudu", "duda", "rocha", "ryan", "tamires", "jonh", "gh", "gean" };

            Random random = new Random();

            int escolhido = random.Next(25);

            Console.WriteLine(nome[escolhido].ToUpper());
        }
    }
}
