using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 5; n++)
            {
                int o = 0;
                for (int k = 1; k <= 5; k++)
                {

                    Console.Write(n + o);
                    o++;
                }
                Console.WriteLine("");
                o++;
            }
        }
    }
}
