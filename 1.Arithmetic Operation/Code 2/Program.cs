using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARITHMETIC OPERATION");
            Console.WriteLine("--------------------");
            Console.WriteLine("ENTER THE NUMBERS 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE NUMBERs 2:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("REPORT");
            Console.WriteLine("------");
            int c = a + b;
            Console.WriteLine("ADDITION:" + c);
            int d = a - b;
            Console.WriteLine("SUBRACTION:" + d);
            int e = a * b;
            Console.WriteLine("MULTIPLICATION:" + e);
            int f = a / b;
            Console.WriteLine("DIVISION:" + f);
            int g = a % b;
            Console.WriteLine("MODULATION:" + g);
            Console.ReadLine();
        }
    }
}
