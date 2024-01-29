using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface IAnimal
    {
        //properties
        string Name { get; set; }
        string Colour { get; set; }
        double Height { get; set; }
        int Age { get; set; }

        //mothods
        void Eat();
        void Cry();
    }
}
