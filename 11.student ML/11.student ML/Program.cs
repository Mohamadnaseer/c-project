using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.student_ML
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Student ML");
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
            
            if (b >= 40 && c >= 40 && d >= 40)
            {
                Console.WriteLine("result:pass");
            }
            else
            {
                Console.WriteLine("result:fail");
            }
            if (e >= 250)
            {
                Console.WriteLine("grade:1 class");
            }
            else if(e >= 200)
            {
                Console.WriteLine("grade:2 class");
            }
            else if (e >= 150)
            {
                Console.WriteLine("grade:3 class");
            }
            else
            {
                Console.WriteLine("grade:4 class");
            }






            Console.ReadLine();
        }
    }
}
