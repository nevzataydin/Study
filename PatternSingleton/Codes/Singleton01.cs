using System;
using System.Collections.Generic;
using System.Text;

namespace PatternSingleton.Codes
{
    class Singleton01
    {
        // Singleton Class.
        public class SingleObject
        {
            //create an object of SingleObject
            private static SingleObject instance = new SingleObject();

            //make the constructor private so that this class cannot be
            //instantiated
            private SingleObject() { }

            //Get the only object available
            public static SingleObject getInstance()
            {
                //think returning object as an expensive operation, like database instance
                return instance;
            }

            public void showMessage()
            {
               Console.WriteLine("Hello World!");
            }
        }
    }
}
