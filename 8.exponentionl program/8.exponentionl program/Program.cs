using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.exponentionl_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXPONENTIAL PROGRAM");
            Console.WriteLine("-------------------");
            Console.WriteLine("ENTER x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER Z:");
            int z = Convert.ToInt32(Console.ReadLine());
            int a = (x * x) + (y * y) + z;
            Console.WriteLine("enter a=" + a);
            int b = (x * y) + (y * z) + (2 * x);
            Console.WriteLine("enter b=" + b);
            int c = (x * x * x) + (y * y * y) + 2 * (x * y) + 2 * (y * x);
            Console.WriteLine("enter c=" + c);
            Console.ReadLine();

        }
    }
}
