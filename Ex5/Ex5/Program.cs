using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5
{
    class Program
    {
        static double hipotenusa(double altura, double basee)
        {
            return  Math.Sqrt((basee * basee) + (altura * altura));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite base: ");
            double basee = double.Parse(Console.ReadLine());
            Console.WriteLine("Hipotenusa: "+hipotenusa(altura,basee));
            Console.ReadKey();
        }
    }
}
