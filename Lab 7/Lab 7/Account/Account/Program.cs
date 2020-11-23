using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts acc1 = new Savings();
            Accounts acc2 = new Savings("X", 6000200, 22000);
            Accounts acc3 = new SpecialSavings("Y", 885522, 12220, 22);

            Accounts acc4 = new Fixed("X", 885844, 9000);

            Accounts acc5 = new Overdraft(3000);
            SpecialSavings s1 = new SpecialSavings(40);
          
            Overdraft od = new Overdraft("X", 667134, 22700, 4500);
        }
    }
}
