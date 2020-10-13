using PatternFactory.Codes;
using System;
using static PatternFactory.Codes.Factory01;

namespace PatternFactory
{
    class Program
    {
        /* https://dotnettutorials.net/lesson/factory-design-pattern-csharp/
        Creational Design Pattern
        a factory is a class with a method. That method will create and return 
            different types of objects based on the input parameter, it received.
         */

        /*Problems without Factory Pattern
        -First, the tight coupling between the client class (Program) and Product Class (MoneyBack, Titanium, and Platinum).
        -Secondly, if we add a new Credit Card, then also we need to modify the Main method by adding an extra if-else 
            condition which not only overheads in the development but also in the testing process
         */

        /* when to use?
        The Object needs to be extended to the subclasses
        Classes don’t know what exact sub-classes it has to create
        The Product implementation going to change over time and the Client remains unchanged
         */
        static void Main(string[] args)
        {
            //factory pattern
            Factory01.Call();

            //abstract factory pattern
            Factory02.Call();

        }
    }
}
