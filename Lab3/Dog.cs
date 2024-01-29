using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Dog: Animal, IAnimal
    {
        //atributes
        public double Height { get; set; }
        //constructor
        public Dog(string name, string colour, int age) : base(name, colour, age) { }
       //methods
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public string Cry()
        {
            return "Woof!";
        }
    }
}
