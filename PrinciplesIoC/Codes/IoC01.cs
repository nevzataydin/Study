using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesIoC.Codes
{
    /*
    INVERSION OF CONTROL as a Principle

    it is used to invert different kinds of controls in object-oriented design to achieve loose coupling


    Control Over the Flow
        the code block that controls the flow of the program
     */
    class IoC01
    {
        static IoC01()
        {
            Console.WriteLine("Inversion of Control");
        }
    }


    class IoC01A
    {
        /*
         class A calls b.SomeMethod() to complete its task1. 
        Class A cannot complete its task without class B and so you can say that 
        "Class A is dependent on class B" or "class B is a dependency of class A".
         */

        public class A
        {
            B b;

            public A()
            {
                b = new B();
            }

            public void Task1()
            {
                // do something here..
                b.SomeMethod();
                // do something here..
            }
        }

        public class B
        {
            public void SomeMethod()
            {
                //doing something..
            }
        }
    }


    class IoC01B
    {
        /*The IoC principle suggests to invert the control. 
         * This means to delegate the control to another class. 
         * In other words, invert the dependency creation control 
         * from class A to another class, as shown below.
         
         */

        public class A
        {
            B b;

            public A()
            {
                b = Factory.GetObjectOfB();
            }

            public void Task1()
            {
                // do something here..
                b.SomeMethod();
                // do something here..
            }
        }

        public class B
        {
            public void SomeMethod()
            {
                //doing something..
            }
        }

        public class Factory
        {
            public static B GetObjectOfB()
            {
                return new B();
            }
        }
    }

    /*
     In an object-oriented design, classes should be designed in a loosely coupled way. 
    Loosely coupled means changes in one class should not force other classes to change, 
    so the whole application can become maintainable and extensible. 
     */

}
