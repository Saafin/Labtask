using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculetor
{
    class Function:  Calculator, basicCalculators, ScientificCalculator
    {
        public Function()
        {

        }

        public Function(string name, string taskType) : base(name, taskType)
        {

        }
        public void Devision(int x, int y)
        {
            int div = x / y;
            Console.WriteLine("The devision is : " + div);
        }

        public void Multiplication(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine("The Multiplication is : " + mul);
        }

        public void Sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("The Sub is : " + sub);
        }

        public void Sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("The Sum is : " + sum);
        }

        public void sc(int x, int y)
        {

            double sc = Math.Pow(x, y);
            Console.WriteLine("The XtoY is  : " + sc);
        }
    }
}
