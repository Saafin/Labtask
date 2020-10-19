using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {   //1
            Console.WriteLine("Hello!");
            Console.WriteLine("Saafin");

            //2
            int x = 5;
            int y = 10;
            int sum = x + y;
            Console.WriteLine("Addition:" + sum);

            //3
            int div = y / x;
            Console.WriteLine("Division:" + div);

            //4
            int a = -5 + 8 * 6;
            Console.WriteLine("a=" + a);
            int b = (55 + 9) % 9;
            Console.WriteLine("b=" + b);
            int c = 20 + -3 * 5 / 8;
            Console.WriteLine("c=" + c);
            int d = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("d=" + d);

            //5
            int n1 = 20;
            int n2 = 10;
            int add = n1 + n2;
            int m = n1 * n2;
            int sub = n1 - n2;
            int divide = n1 / n2;
            Console.WriteLine("Addition: " + add);
            Console.WriteLine("Multiplication: " + m);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Division: " + divide);

            //6
            double compute = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("Solution: " + compute);

            //7
            double width = 5.5;
            double height = 8.5;
            Console.WriteLine("Area is: " + 5.5 * 8.5);
            Console.WriteLine("Perimeter is: " + 2 * (5.5 + 8.5));

           


        }
    }
}
