using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double diferenca(double x, double y)
        {
            if (x > y)
            {
                return x - y;
            }
            else
            {
                return y - x;
            }
        }
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            Console.WriteLine("Diferença entre x e y: " + diferenca(x, y));
            Console.ReadKey();
        }
    }
}
