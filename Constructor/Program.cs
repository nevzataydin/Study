using Constructor.Codes;
using System;

namespace Constructor
{
    class Program
    {
        /*
            Executed when the object is created
            Responsible for object initialization
            Responsible for memory allocation of its class
            New keyword role is creating the object
         */
        static void Main(string[] args)
        {
            new Constructor01();

            new Constructor02("\nI am a parameterized constructor");

            var constructor03 = new Constructor03();
            constructor03.MyProperty01 = 5;
            constructor03.MyProperty02 = 7;
            var constructor03v2 = new Constructor03(constructor03);
            Console.WriteLine("\nI am a copy constructor. \nMy values are {0} and {1}", constructor03v2.MyProperty01, constructor03v2.MyProperty02);

            new Constructor04();
            new Constructor04();
            new Constructor04();

            Constructor05.Counter.currentCount = 100;
            Constructor05.Counter.IncrementCount();
            Console.WriteLine("\nPrivate constructor\nNew count: {0}", Constructor05.Counter.currentCount);

            var constructor06 = new Constructor06();
            constructor06.ReadFile();
            Console.WriteLine("End");


        }
    }
}
