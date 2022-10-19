using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppBasics
{
    class Program
    {
        public String name;
        public int age;

        public void method(String name, int age)
        {
            this.name = name;
            this.age = age;

            // Console.WriteLine("name " + name + " age " + age);
        }


    }
    class Program2 : Program
    {
        public Program2()
        {
            Console.WriteLine("Details");
        }
    }
    class Program3
    {
        public static void Main(string[] args)
        {
            Program2 prg = new Program2();
            //prg.method("Manasa", 21);
            // name=Console.ReadLine();
            // prg.method(name,age);
            String name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name " + name + "Age " + age);
        }
    }
}

