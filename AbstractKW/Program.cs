using AbstractKW.Codes;
using System;

namespace AbstractKW
{
    class Program
    {
        /*
         When we have a requirement where our base class should provide 
        the default implementation of certain methods whereas other methods 
        should be open to being overridden by child classes use abstract classes.

        If we have an implementation that will be the same for all the derived classes, 
        then it is better to go for an abstract class instead of an interface. 
        
        So, when we have an interface, we can move our implementation to any class 
        that implements the interface. 

         */

        /*
         	Are not completed
	            Must be implemented in a derived class
	            You can add abstract methods in abstract classes
		            This way you can have methods with parameters without defining their tasks

         */
        static void Main(string[] args)
        {
            var derived01 = new Abstract01.Derived01();
            derived01.Method01(); //abstract parent
            derived01.Method02(); //derived
            derived01.Method03(); //derived
            derived01.Method04(); //abstract parent
            derived01.Method05(); //derived

            Console.WriteLine("\n1st level Parent abstract class. two more abstract class inherits me");
            var derived02 = new Abstract02.Derived01();
            derived02.Method01();
            derived02.Method02();
            var derived03 = new Abstract02.Derived02();
            derived03.Method01();
            derived03.Method03();
            var derived04 = new Abstract02.Derived03();
            derived04.Method01();
            derived04.Method05();

        }
    }
}

