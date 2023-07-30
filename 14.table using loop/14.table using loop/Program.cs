using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.table_using_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("table using for loop");
            Console.WriteLine("--------------------");
            Console.WriteLine("enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the nth table");
            Console.WriteLine("-------------------");
            for (int i = 1; i <=100;i++)
            {
                Console.WriteLine(i + "x" + a + "=" + i * a);
            }
            Console.ReadLine();
        }
    }
}
