using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class exer26B
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o seu salário:");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o percentual do aumento:");
            double reajuste = Convert.ToDouble(Console.ReadLine());

            double salarioNovo = salario + (salario / reajuste);

            Console.WriteLine("seu salário novo é: " + salarioNovo);
        }
    }
}
