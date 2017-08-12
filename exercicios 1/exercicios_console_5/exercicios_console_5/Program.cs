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

            int x = int.Parse(Console.ReadLine());
            if (x > 50 || x < 1)
            {
                Console.WriteLine("número inválido");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("For:");
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
