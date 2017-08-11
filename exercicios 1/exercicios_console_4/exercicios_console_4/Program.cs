using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicios_console_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("Janeiro");
            }
            else if (x == 2)
            {
                Console.WriteLine("Fevereiro");
            }
            else if (x == 3)
            {
                Console.WriteLine("Março");
            }
            else if (x == 4)
            {
                Console.WriteLine("Abril");
            }
            else if (x == 5)
            {
                Console.WriteLine("Maio");
            }
            else if (x == 6)
            {
                Console.WriteLine("Junho");
            }
            else if (x == 7)
            {
                Console.WriteLine("Julho");
            }
            else if (x == 8)
            {
                Console.WriteLine("Agosto");
            }
            else if (x == 9)
            {
                Console.WriteLine("Setembro");
            }
            else if (x == 10)
            {
                Console.WriteLine("Outubro");
            }
            else if (x == 11)
            {
                Console.WriteLine("Novembro");
            }
            else if (x == 12)
            {
                Console.WriteLine("Dezembro");
            }
            else
            {
                Console.WriteLine(x + " é um Mês inessistente");
            }
            Console.ReadKey();
        }
    }
}
