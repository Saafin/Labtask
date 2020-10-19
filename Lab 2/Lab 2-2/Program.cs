using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)  
            {
                for (int j = 0; j < 6; j++)
                {
                    if ((j + i) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else if ((j + i) % 2 == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("Neither X nor O"); 
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
