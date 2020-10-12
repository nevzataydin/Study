using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Codes
{
    class Polymorphism02
    {
        internal class Parent
        {
            /*
            Static / compile time / early binding
            In Overloading.Different signatures allow it to choosen in ct
            */
            static Parent()
            {
                Console.WriteLine("constructor and method overload");
            }
        }
        internal class Child : Parent
        {
            internal Child()
            {
                Console.WriteLine("constructor overload 1");
            }

            internal Child(string value)
            {
                Console.WriteLine("constructor overload " + value);
            }

            internal string Method()
            {
                return "I am overload 1";
            }

            internal string Method(string value)
            {
                return "I am overload " + value;
            }
        }
    }

}
