using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics2
{
    public class Program
    {

        public int add(int a, int b)
        {
            int res;
            res = a + b;
            return res;
        }
        public int add(int a, int b, int c)
        {
            int res;
            res = a + b + c;
            return res;

        }

        public static void Main(string[] args)

        {
            Program obj1 = new Program();
            int sum1 = obj1.add(1, 2);
            Console.WriteLine("sum:" + sum1);
            int sum2 = obj1.add(2, 3);
            Console.WriteLine("sum:" + sum2);
            int sum3 = obj1.add(3, 4, 5);
            Console.WriteLine("sum:" + sum3);

        }
    }
}

