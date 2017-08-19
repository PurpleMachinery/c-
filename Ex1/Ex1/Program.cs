using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double lerNota()
        {
            return double.Parse(Console.ReadLine());
        }
        static double calcularMedia(double x, double y)
        {
            return (x+y)/2;
        }
        static void Main(string[] args)
        {
            double[] x = new double[2];
            for (int i = 0; i < 2; i++)
            {
                x[i] = lerNota();
            }
            Console.WriteLine("Média: " + calcularMedia(x[0], x[1]));
            if (calcularMedia(x[0], x[1]) >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
            Console.ReadKey();
        }
    }
}
