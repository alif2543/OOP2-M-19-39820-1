using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("rakib", "1515", 20232000);
            Account a2 = new Account("rezoan", "4564", 500065560);
            Console.WriteLine();
            a1.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a1.Transfer(500, a2);
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine();

            a2.ShowInfo();
            a2.deposit(2000);
            a2.withdraw(5000);
            a2.Transfer(200, a1);
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine();

            Savings s1 = new Savings("audry", "7878", 153400);
            s1.ShowInfo();
            s1.withdraw(500);
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine();

            SpecialCurrent s2 = new SpecialCurrent("shuvo", "5959", 1556700);
            s2.ShowInfo();
            s2.withdraw(3000);
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine();


            Fixed f1 = new Fixed("tonmoy", "9665", 1000000);
            f1.ShowInfo();
            f1.withdraw(3000);
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine();


            OverDraft o = new OverDraft("nila", "3636", 105000);
            o.ShowInfo();
            o.withdraw(200);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
