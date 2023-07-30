using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Of n No");
            Console.WriteLine("-----------");
            Console.WriteLine("Enter The Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Report");
            Console.WriteLine("------");
            int b = a * (a + 1) / 2;
            Console.WriteLine("sum:" + b);
            int c = (a * a + 1) * (2 * a + 1) / 6;
            Console.WriteLine("sum:" + c);
            int d = (a * (a + 1 / 2)) * (a * (a + 1 / 2));
            Console.WriteLine("sum:" + d);
            Console.ReadLine();
        }
    }
}
