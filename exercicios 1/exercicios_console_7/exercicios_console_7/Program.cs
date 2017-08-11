using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicios_console_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double a = 150, m = 110;
            for (i = 0; a >= m; )
            {
                a += 2;
                m += 3;
                i++;
            }
            Console.WriteLine(i + " anos");
            Console.ReadKey();
        }
    }
}
