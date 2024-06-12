using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManzano
{
    internal class casting
    {
        public static void Main(string[] args)
        {
            /*  
              double myDouble = 43.17;
              int myInt = (int) myDouble;
              Console.WriteLine(myInt);
              Console.WriteLine(myDouble); */

            int myInt = 74;
            double myDouble = 12.55;
            bool myBool = false;
            char myChar ='C';

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Convert.ToString(myChar));
        }
    }
}
