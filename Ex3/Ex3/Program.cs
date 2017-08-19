using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void printf(String x)
        {
            Console.WriteLine(x);
        }
        static void insi()
        {
            Console.Write("Digite um numero: ");
        }
        static void soma()
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite um numero: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(x+" + "+y+" = "+(x+y));
        }
        static void subt()
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine()); 
            Console.Write("Digite um numero: "); 
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(x + " - " + y + " = " + (x - y));
        }
        static void div()
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite um numero: "); 
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(x + " / " + y + " = " + (x / y));
        }
        static void mult()
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine()); 
            Console.Write("Digite um numero: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(x + " * " + y + " = " + (x * y));
        }
        static void rest()
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite um numero: "); 
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(x + " % " + y + " = " + (x % y));
        }
        static void dobro()
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(x + " * " + 2 + " = " + (x * 2));
        }
        static void quad()
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(x + " * " + x + " = " + (x * x));
        }
        static void cubo()
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(x + " * " + x + " * " + x + " = " + (x * x * x));
        }
        static void raiz()
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Raiz de "+x+": "+Math.Sqrt(x));
        }
        static void Main(string[] args)
        {
            printf("1 - Soma");
            printf("2 - Subtração");
            printf("3 - Divisão");
            printf("4 - Multiplicação");
            printf("5 - Resto");
            printf("6 - Dobro");
            printf("7 - Quadrado");
            printf("8 - Cubo");
            printf("9 - Raiz Quadrada");
            printf("0 - Sair");
            Console.Write("Escolha: ");
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 1:
                    soma();
                    break;
                case 2:
                    subt();
                    break;
                case 3:
                    div();
                    break;
                case 4:
                    mult();
                    break;
                case 5:
                    rest();
                    break;
                case 6:
                    dobro();
                    break;
                case 7:
                    quad();
                    break;
                case 8:
                    cubo();
                    break;
                case 9:
                    raiz();
                    break;
                default:
                    return;
            }








            Console.ReadKey();
        }
    }
}
