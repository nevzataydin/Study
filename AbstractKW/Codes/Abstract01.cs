using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractKW.Codes
{
    class Abstract01
    {
        internal abstract class Abs01
        {
            internal Abs01()
            {
                Console.WriteLine("Abstract, virtual, override, sealed");
            }

            //normal method
            internal void Method01()
            {
                Console.WriteLine("I am a normal method in the abstract class");
            }

            //abstract method, to be mandatorily overriden in the derived class.
            internal abstract void Method03();

            //virtual methods can be overriden like abstract methods but doesn't implemented
            internal virtual void Method04()
            {
                Console.WriteLine("I am a virtual method in an abstract class");
            }

            internal virtual void Method05()
            {
                Console.WriteLine("I am a virtual method in an abstract class. I can be overriden.");
            }

        }

        //sealed classes cannot be inherited
        internal sealed class Derived01 : Abs01
        {
            internal void Method02()
            {
                Console.WriteLine("I am an derived class");
            }

            internal override void Method03()
            {
                Console.WriteLine("I am an overriden abstract method in the derived class, from parent abstract class.");
            }

            internal override void Method05()
            {
                base.Method05();
            }

        }

        //sealed classes cannot be inherited
        //internal class Derived02: Derived01 { }
    }
}
