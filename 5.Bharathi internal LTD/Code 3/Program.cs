using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BHARATHI INTERNAL[P]LTD\nNEHRU STREET,PONDICHERRY.\n----------------------------\nEMPLOYEE PAYROLL SYSTEM\n--------------------");
            Console.WriteLine("EMPLOYEE ID:");
            string id = Console.ReadLine();
            Console.WriteLine("EMPLOYEE NAME:");
            string name = Console.ReadLine();
            Console.WriteLine("salary");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------");
            Console.WriteLine("INCOME");
            int b = a * 10 / 100;
            Console.WriteLine("BONUS (10%)=" + b);
            int c = a * 5 / 100;
            Console.WriteLine("INCREMENT (5%)=" + c);
            int d = a * 3 / 100;
            Console.WriteLine(" HRA (3%)=" + d);
            int e = a + b + c + d;
            Console.WriteLine("GROSS PAY=" + e);

            Console.WriteLine("-------------------------");


            Console.WriteLine("EXPENDITURE");
            int f = a * 2 / 100;
            Console.WriteLine("PF AMOUNT(2%)" + f);
            int g = a * 2 / 100;
            Console.WriteLine("LIC INSURANCE(1%)" + g);
            int h = f + g - e;

            Console.WriteLine("NET PAY:" + h);

            Console.ReadLine();
        }
    }
}
