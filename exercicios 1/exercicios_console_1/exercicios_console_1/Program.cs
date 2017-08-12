using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicios_console_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            x+=y;
            if (x > 20) Console.WriteLine(x + 8);
            else Console.WriteLine(x - 5);
        }
    }
}
