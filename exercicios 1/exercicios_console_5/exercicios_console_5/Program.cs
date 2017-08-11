using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicios_console_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For:");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n\nWhile");
            int y = 1;
            while (y <= x)
            {
                Console.WriteLine(y);
                y++;
            }

            Console.WriteLine("\n\n\nDo-While");
            int z = 1;
            do
            {
                Console.WriteLine(z);
                z++;
            } while (z <= x) ;
            Console.ReadKey();
        }
    }
}
