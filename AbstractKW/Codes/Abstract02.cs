using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractKW.Codes
{
    internal class Abstract02
    {
        internal abstract class Abs01
        {
            //must be overriden in the inherited normal classes
            internal abstract void Method01();
        }

        internal abstract class Abs02 : Abs01
        {
            internal abstract void Method02();
        }

        internal abstract class Abs03 : Abs01
        {
            internal abstract void Method03();
        }

        internal class Derived01 : Abs02
        {
            internal override void Method01()
            {
                Console.WriteLine("overriden from 1st lvl abstract parent");
            }

            internal override void Method02()
            {
                Console.WriteLine("overriden from 2nd lvl abstract parent");
            }
        }

        internal class Derived02 : Abs03
        {
            internal override void Method01()
            {
                Console.WriteLine("overriden from 1st lvl abstract parent");
            }

            internal override void Method03()
            {
                Console.WriteLine("overriden from 2nd lvl abstract parent");
            }

            internal virtual void Method05()
            {
                Console.WriteLine("I am a virtual method from Derived02 class, used by Derived03 class");
            }

            //abstract methods cannot be placed in the non abstract classes
            //internal abstract void Method06();
        }

        internal abstract class Abs04 : Derived02
        {
            internal new void Method01()
            {
                Console.WriteLine("I override my parent's abstract method (Method01) with new key word");
            }
        }

        internal class Derived03 : Abs04
        {
            internal override void Method05()
            {
                base.Method05();
            }
        }
    }
}
