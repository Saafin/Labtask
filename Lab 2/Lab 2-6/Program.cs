using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f = 1, n = 5;
            for (i = 1; i <= n; i++)
            {
                f = f * i;

            }
            Console.Write(" Factorial of " + n + " is:  " + f);
        }
    }
}
