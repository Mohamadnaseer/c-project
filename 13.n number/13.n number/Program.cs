using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.n_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of number\n-------------");
            Console.WriteLine("enter teh starting no");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the end no");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("report\n------");
            int count = 0;
            int sum = 0;
            for (int i = a; i < b; i++) 
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine("i:" + i);
                    count++;
                    sum = sum+i;
                }
            }
            Console.WriteLine("count:" + count);
            Console.WriteLine("sum:" + sum);
            Console.ReadLine();
        }
    }
}
