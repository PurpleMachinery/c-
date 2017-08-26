using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double calcularPesoIdeal(double x, char y)
        {
            if (y == 'm'||y=='M')
            {
                return x * 72.7 - 58;
            }
            else if(y == 'f'||y=='F')
            {
                return x * 62.1 - 44.7;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite 'M' para homem e 'F' para mulher: ");
            char l = char.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            double alt = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor ideal: " + calcularPesoIdeal(alt, l));



            Console.ReadKey();
        }
    }
}
