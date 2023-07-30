using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GOVERNMENT OF PUDUCHERRY\n ELECTRICITY BILL\n ------------------");
            Console.WriteLine("EB NO:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CUSTOMER NAME:");
            string str = Console.ReadLine();
            Console.WriteLine("PREVIOUS UNIT:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CURRENT UNIT:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("AMOUNT PER UNIT:");
            int d = Convert.ToInt32(Console.ReadLine());

            int e = b - c;
            Console.WriteLine("UNIT READING:" + e);
            int f = c + e;
            Console.WriteLine("AMOUNT=" + f);
            int g = e * 100 / 10;
            Console.WriteLine("GST(10%)=" + g);
            int h = f + g;
            Console.WriteLine("TOTAL AMOUNT:" + h);



            Console.ReadLine();
        }
    }
}
