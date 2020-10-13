using PatternSingleton.Codes;
using System;

namespace PatternSingleton
{
    class Program
    {
        // https://www.tutorialspoint.com/design_pattern/singleton_pattern.htm
        /*
         We need to use the Singleton Design Pattern in C# when we need to ensures 
        that only one instance of a particular class is going to be created and
        then provide simple global access to that instance for the entire application.
         */
        static void Main(string[] args)
        {
            var singleton01 = Singleton01.SingleObject.getInstance();

            //show the message
            singleton01.showMessage();

            //because it is static, wherever we call it, it wont be created again (if not destructed)
        }
    }
}
