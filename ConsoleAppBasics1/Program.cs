using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics1
{

    public class Program
    {
        private String name;
        private int age;

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
    class MAINS
    {
        public static void Main(string[] args)
        {
            Program bj = new Program();
            bj.Name = "Manasa";
            bj.Age = 22;
            Console.WriteLine(bj.Name);
            Console.WriteLine(bj.Age);
        }
    }
}

