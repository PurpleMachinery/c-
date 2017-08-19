using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void calcularPesoIdeal(double x, char y)
        {
            if (y == 'h'||y=='H')
            {
                Console.WriteLine("Peso ideal: " + (x * 72.7 - 58));
            }
            else if(y == 'm'||y=='M')
            {
                Console.WriteLine("Peso ideal: " + (x * 62.1 - 44.7));
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite 'H' para homem, ou 'M' para mulher: ");
            char l=char.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            calcularPesoIdeal(double.Parse(Console.ReadLine()), l);
            Console.ReadKey();
        }
    }
}
