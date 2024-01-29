/*
Project Name: Lab 3: Interfaces and Abstract Classes
By: Adam Nordquist
Date: January 29, 2024
Description: creates an abstract and an interface class for animals.
*/
namespace Lab3;

    internal class Program
    {
        static void Main()
        {
            //create objects
            Dog Ember = new Dog("Ember", "Black and White", 2);
            Ember.Height = 40.2;
            Dog Murdoch = new Dog("Murdoch", "Brown", 3);
            Murdoch.Height = 55.0;
            Cat Riley = new Cat("Riley", "Orange and white", 8);
            Riley.Height = 18.8;
            Cat Toby = new Cat("Toby", "Tabbie", 10);
            Toby.Height = 17.6;

            //Ember  object methods 
            Console.WriteLine("Animal's Name: " + Ember.Name);
            Console.WriteLine("Animal's Colour: " + Ember.Colour);
            Console.WriteLine("Animal's Height: " + Ember.Height + " inches");
            Console.WriteLine("Animal's Age: " + Ember.Age + " years old");
            Ember.Eat();
            Console.WriteLine(Ember.Name + " goes " + Ember.Cry() + "\n");

            //Riley object methods 
            Console.WriteLine("Animal's Name: " + Riley.Name);
            Console.WriteLine("Animal's Colour: " + Riley.Colour);
            Console.WriteLine("Animal's Height: " + Riley.Height + " inches");
            Console.WriteLine("Animal's Age: " + Riley.Age + " years old");
            Riley.Eat();
            Console.WriteLine(Riley.Name + " goes " + Riley.Cry() + "\n");

            //create and print list
            List<Animal> animals = new List<Animal>();
            animals.Add(Ember);
            animals.Add(Murdoch);
            animals.Add(Riley);
            animals.Add(Toby);

            Console.WriteLine("A list of all the animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }