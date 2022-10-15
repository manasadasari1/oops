using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppclassobject
{
    public class Bird
    {
        String Name;
        String Breed;
        String Color;
        int age;
        public Bird(String names, String breed, String color, int age)
        {
            this.Name = names;
            this.Breed = breed;
            this.Color = color;
            this.age = age;
        }
        public String getName()
        {
            return Name;
        }
        public String getBreed()
        {
            return Breed;

        }
        public String getColor()
        {
            return Color;

        }
        public int getage()
        {
            return age;
        }
        public String ToS()
        {
            return (this.getName() + " name " + this.getBreed() + " Breed " + this.getColor() + " Color " + this.getage() + " age");
        }
        public static void Main(String[] args)
        {
            Bird fly = new Bird("Butterfly", "lady", "blue", 10);

            Console.WriteLine(fly.ToS());
        }
    }
}
    
