using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Traiangle__area_and_peri_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle\n------------");
            Console.WriteLine("enter the breadth:");
            int bre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter teh height:");
            int hei = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("report\n----------");
            int area = (1 *bre * hei)/2;
            Console.WriteLine("area of traigle:" + area);
            int peri = a + b + c;
            Console.WriteLine("perimeter of traigle:" + peri);
            Console.ReadLine();

        
        }
    }
}
