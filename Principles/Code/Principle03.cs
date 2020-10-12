using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesSOLID.Code
{

    //3
    /*
     The Open/Closed Principle, which I explained in a previous article, 
    is one of the key concepts in OOP that enables you to write robust,
    maintainable and reusable software components. 
    But following the rules of that principle alone is not enough 
    to ensure that you can change one part of your system without breaking other parts. 
    Your classes and interfaces also need to follow the Liskov Substitution Principle 
    to avoid any side-effects.
     */

    class Principle03
    {
        static Principle03()
        {
            Console.WriteLine("Liskov Substitution Principle");
        }

        //you can use abstract-override or virtual-override 
        internal abstract class Fruit
        {
            public abstract string GetColor();
        }
        internal class Apple : Fruit
        {
            public override string GetColor()
            {
                return "Red";
            }
        }
        internal class Orange : Fruit
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }

        internal void Call()
        {
            Console.WriteLine("\nLiskov. object (fruit) is replace by its subtypes (apple and orange)");
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
