using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ACHARIYA ARTS AND SCIENCE COLLEGE");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("REG NO:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NAME:");
            string str = Console.ReadLine();
            Console.WriteLine("mark 1:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mark 2:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mark 3:");
            int d = Convert.ToInt32(Console.ReadLine());
            int e = b + c + d;
            Console.WriteLine("total:" + e);
            int f = e / 3;
            Console.WriteLine("percentage:" + f);
            Console.ReadLine();
        }
    }
}
