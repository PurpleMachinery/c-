using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=double.Parse(Console.ReadLine()), y=double.Parse(Console.ReadLine());
            x += y;
            if (x > 20)
            {
                x += 8;
            }
            else
            {
                x -= 5;
            }



            Console.WriteLine("Resultado: " + x);
            Console.ReadKey();
        }
    }
}
