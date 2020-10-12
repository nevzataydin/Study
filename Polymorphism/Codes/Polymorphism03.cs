using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Polymorphism.Codes
{
    class Polymorphism03
    {
        internal class Parent
        {
            static Parent()
            {
                Console.WriteLine("I am hiding parents methdos. \nDoes not matter if we use new keyword anymore.");
            }

            internal string Method()
            {
                return "I am parent";
            }

            internal string Method2()
            {
                return "I am parent 2";
            }
        }

        internal class Child
        {
            internal new string Method()
            {
                return "I am hiding my parent";
            }

            internal string Method2()
            {
                return "I am hiding my parent 2";
            }
        }
    }
}
