using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Code_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("circle program");
            Console.WriteLine("--------------");
            Console.WriteLine("enter the radius:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("report");
            Console.WriteLine("------");
            int b = 22 / 7 * a * a;
            Console.WriteLine("AREA OF THE CIRCLE:" + b);
            int c = 2 * 22 / 7 * a;
            Console.WriteLine("perimeter of the circle:" + c);
            Console.ReadLine();
        }
    }
}
