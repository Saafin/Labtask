using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    class Studentsm
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write your name:");
            String n = Console.ReadLine();
            Console.WriteLine("Write your ID:");
            String i = Console.ReadLine();
            Console.WriteLine("Write your Department:");
            String d = Console.ReadLine();
            Console.WriteLine("Write your CGPA:");
            float c = Console.Read();
            Students s = new Students(n, i, d, c);
            s.ShowInfo();
        }
    }
}

