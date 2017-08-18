using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void dobro(int x)
        {
            Console.WriteLine(x+" * 2 = "+(x*2));
        }
        static void digite()
        {
            Console.Write("Digite um numero: ");
        }
        static void soma(int x, int y)
        {
            Console.WriteLine(x + " + " + y + " = " + (x + y));
        }
        static void mult(int x, int y)
        {
            Console.WriteLine(x + " * " + y + " = " + (x * y));
        }
        static void Main(string[] args)
        {
            int n1, n2;
            digite();
            n1=int.Parse(Console.ReadLine());
            digite();
            n2=int.Parse(Console.ReadLine());
            soma(n1, n2);
            mult(n1, n2);
            dobro(n1);
            dobro(n2);
            Console.ReadKey();
        }
    }
}
