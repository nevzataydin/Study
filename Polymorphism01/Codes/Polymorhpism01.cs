using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Codes
{
    class Polymorhpism01
    {

        //overriding
        //	Dynamic / run time / late binding

        internal class Parent
        {
            internal virtual string Method()
            {
                return "I am parent";
            }
        }

        //overrides parent's Method method
        internal class Child : Parent
        {
            internal override string Method()
            {
                return "I am child";
            }
        }

        //calls parent's Methods method
        internal class Child2 : Parent
        {

        }
    }
}
