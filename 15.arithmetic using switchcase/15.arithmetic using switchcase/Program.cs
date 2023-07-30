using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.arithmetic_using_switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("arithmetic using case\n-----------------");
            Console.WriteLine("menu:\n1.add\t2.sub\t3.mul\t4.div");
            Console.WriteLine("enter the choice");
            int choice=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number");
            int b=Convert.ToInt32(Console.ReadLine());
            int c=0;
            switch(choice)
            {
                case 1:
                    c=a+b;
                    Console.WriteLine("add:"+c);
                    break;
                case 2:
                    c=a-b;
                    Console.WriteLine("sub:"+c);
                    break;
                case 3:
                    c=a*b;
                    Console.WriteLine("mul:"+c);
                    break;
                case 4:
                    c=a/b;
                    Console.WriteLine("div:"+c);
                    break;
                default:
                    Console.WriteLine("default value");
                    break;
            }
            Console.ReadLine();
        }
    }
}
