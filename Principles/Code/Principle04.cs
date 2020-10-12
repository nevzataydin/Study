using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesSOLID.Code
{
    internal class Principle04
    {
        /*
         	once an interface is becoming too large, we need to split it into small interfaces that are more specific. 
            And interface will be defined by the client that will use it, 
        which means that client of the interface will only know about the methods that are related to them.

        if you implement non-usable methods to a class via interface, you are doing it wrong.
        chop interfaces as needed.

         */
        static Principle04()
        {
            Console.WriteLine("\nInterface Segregation Principle: ");
        }

        //must use public everywhere to use methods in class instances
        public interface Intf01
        {
            public void Mth01();
        }

        public interface Intf02
        {
            public void Mth02();

        }

        public class Cls01 : Intf01, Intf02
        {
            public void Mth01()
            {
                Console.WriteLine("I am from first interface in first class");
            }

            public void Mth02()
            {
                Console.WriteLine("I am from second interface in first class");
            }

        }

        public class Cls02 : Intf01
        {
            public void Mth01()
            {
                Console.WriteLine("I am from first interface in second class");
            }
        }
    }
}
