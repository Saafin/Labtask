﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }

    }
}
}
