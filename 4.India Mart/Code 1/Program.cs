using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("INDIA MART\nPONDICHERRY\n----------------\nBILL RECEIPT\n----------------");
            
            Console.WriteLine("ENTER THE SI:NO");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE PARTICULAR :");
            string str = Console.ReadLine();

            Console.WriteLine("ENTER THE RATE:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE QUANTITY:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE RATE:"+d);
            int e = d * c;
            Console.WriteLine("TOTAL AMOUNT (RS):" + e);
            int f = e * 12/100;
            Console.WriteLine("GST(12%):" + f);
            int g = e + f;
            Console.WriteLine("TOTAL AMOUNT:" + g);


            Console.ReadLine();
        

        }
    }
}
