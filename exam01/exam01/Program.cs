using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write how many rows ");
            int n = Convert.ToInt32(Console.ReadLine());
            shape(n);

            Console.WriteLine("Write your number ");
            int num = Convert.ToInt32(Console.ReadLine());
            calculate(num);
            Console.ReadLine();

            Console.WriteLine("write num to get a factorial for ");
            int number = Convert.ToInt32(Console.ReadLine());
            int resultFac = fac(number);
            Console.WriteLine("factoral result is {0}", resultFac);
            Console.ReadLine();



        }
        public static void shape(int n)
    {
        for (int i = n; i > 0; --i)
        {
            for (int j = 0; j < i; ++j)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }


        Console.ReadLine();
    }

        public static void calculate(int num)
        {
            int res = 0;
            while(num != 0)
            {
                res +=num % 10;
                num /= 10;

            }
            Console.WriteLine("total is {0} ",res);

        }

        public static int fac(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * fac(n - 1);
        }
}
}
