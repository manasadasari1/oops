using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics3
{
    abstract class Program
    {
        public abstract int area();
    }
    class Prog : Program
    {
        int side;


        public Prog()
        {
            side = 1;
        }



        public override int area()
        {
            return side * side;
        }
    }
    class MAins
    {
        public static void Main(string[] args)
        {
            Prog obj = new Prog();
            Console.WriteLine(obj.area());
        }
    }
}
