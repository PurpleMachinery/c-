using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        int soma(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int n1, n2, t1;
            Program pp = new Program();
            n1=int.Parse(Console.ReadLine());
            n2=int.Parse(Console.ReadLine());
            t1=n1+n2;
            Console.WriteLine(n1 + " + " + n2 + " = " + pp.soma(n1, n2));
            Console.ReadKey();
        }
    }
}
