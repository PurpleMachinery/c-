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
            double a=double.Parse(Console.ReadLine()), b=double.Parse(Console.ReadLine()), c=double.Parse(Console.ReadLine());
            if((a==b)&&(b==c)){
                Console.WriteLine("Triangulo equilatero");
            }
            else if (((a == b) && (a != c))||((a==c)&&(a!=b))||((b==c)&&(b!=a)))
            {
                Console.WriteLine("Triangulo isósales");
            }
            else if ((a != b) && (b != c) && (a != c))
            {
                Console.WriteLine("Triangulo escaleno");
            }
            Console.ReadKey();
        }
    }
}
