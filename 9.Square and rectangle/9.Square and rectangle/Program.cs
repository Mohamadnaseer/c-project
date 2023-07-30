using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Square_and_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("square");
            Console.WriteLine("------");
            Console.WriteLine("enter the value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("rectangle");
            Console.WriteLine("---------");
            Console.WriteLine("enter the length");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the breath");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("REPORT");
            Console.WriteLine("------");
            int square = a * a;
            Console.WriteLine("area of square:" + square);
            int peri = 4 * a;
            Console.WriteLine("perimeter of square:" + peri);
            int rec = (l * b);
            Console.WriteLine("area of rectangle:" + rec);
            int perim = 2 * (l * b);
            Console.WriteLine("perimeter of rectangle:" + perim);

            Console.ReadLine();
        }
    }
}
