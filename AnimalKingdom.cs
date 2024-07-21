using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    /// <summary>
    /// In C#, there are 4 types of inheritance:
    /// Single inheritance: A derived class that inherits from only one base class.
    /// 
    /// Multi-level inheritance: A derived class that inherits from a base class and the derived class itself 
    /// becomes the base class for another derived class.
    /// 
    /// Hierarchical inheritance: A base class that serves as a parent class for two or more derived classes.
    /// 
    ///Multiple inheritance: It is possible with the help of Interfaces.
    /// </summary>
    public class AnimalKingdom
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    public class Dog : AnimalKingdom
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    public class Mammal : AnimalKingdom
    {
        public void run()
        {
            Console.WriteLine("The mamal is running");
        }
    }
    public class Horse : Mammal
    {
        public void Gallop()
        {
            Console.WriteLine("The horse is galloping");
        }
    }
    public class Bird : AnimalKingdom
    {
        public void Fly()
        {
            Console.WriteLine("Birds are flying");
        }
    }

    public class Eagle : Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting");
        }
    }
    public class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming");
        }
    }
    interface I1
    {
        void Method1();
    }
    interface I2
    {
        void Method2();
    }

    public class MyClass : I1, I2
    {
        public void Method1() { Console.WriteLine("This is Method 1"); }
        public void Method2() { Console.WriteLine("This is Method 2"); }
    }
}
