using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Cat : Animal, IAnimal
    {
        //attributes
        public double Height { get; set; }
        //constructor
        public Cat(string name, string colour, int age): base(name, colour, age) { }
        //methods
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public void Cry()
        {
            Console.WriteLine("Meow!");
        }
    }
}
