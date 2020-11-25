using System;

namespace BasicCalculetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Function c1 = new Function("Math", "Easy");
            c1.Sum(3, 3);
            c1.ShowInfo();
            Function c2 = new Function("Physics", "Hard");
            c2.Devision(5, 4);
            c1.ShowInfo();

            c1.sc(3, 3);
            c1.ShowInfo();
        }
    }
}
