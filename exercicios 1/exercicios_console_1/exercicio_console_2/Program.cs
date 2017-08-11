using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio_console_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool y=false;
            double x = double.Parse(Console.ReadLine());
            if (x % 10 == 0)
            {
                Console.WriteLine("Divisivel por 10");
                y=true;
            }
            if (x % 5 == 0)
            {
                Console.WriteLine("Divisivel por 5");
                y=true;
            }
            if (x % 2 == 0)
            {
                Console.WriteLine("Divisivel por 2");
                y=true;
            }
            else if (y == false)
            {
                Console.WriteLine("Não é divisivel por 10, 5 nem 2.");
            }
        }
    }
}
