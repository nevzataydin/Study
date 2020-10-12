using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Codes
{
    class Constructor05
    {
        /*
         	5. Private Constructor: used to creating an object for the class within the same class. Used for remoting concept
		        a. When we want the caller of the class only to use the class but not instantiate. 
		        b. If you want to ensure a class can have only one instance at a given time, i.e. private constructors are used in implementing Singleton() design pattern.
		        c. When a class has several overloads of the constructor, and some of them should only be used by the other constructors and not external code.
         
            A private constructor is a special instance constructor. 
        It is generally used in classes that contain static members only. 
        If a class has one or more private constructors and no public constructors, 
        other classes (except nested classes) cannot create instances of this class.

            The declaration of the empty constructor prevents the automatic generation of a parameterless constructor. 
        Note that if you do not use an access modifier with the constructor it will still be private by default. 
        However, the private modifier is usually used explicitly to make it clear that the class cannot be instantiated.
         */

        public class Counter
        {
            //private is default. we place private to explictly indicate
            private Counter() {
                Console.WriteLine("\nI am a private constructor. i cannot be called");
            }
            public static int currentCount;
            public static int IncrementCount()
            {
                return ++currentCount;
            }
        }
    }
}
