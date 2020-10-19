using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sumx = 0;
            for (int i = 1; i <= 100; i++)
            {

                if (i % 2 == 0)
                {
                    sum = sum + i;
                }

                if (i % 2 != 0)
                {
                    sumx = sumx + i;
                }

            }
            Console.WriteLine("The sum of Even number:");
            Console.WriteLine(sum);
            Console.WriteLine("The sum of odd number:");
            Console.WriteLine(sumx);
        }
    }
}
