using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesSOLID.Code
{
    class Principle02
    {
    }

    //2
    internal class ExtensionParent
    {
        static ExtensionParent()
        {
            Console.WriteLine("\nOpen Closed Principle: Dont change me, extend me.");
        }
    }

    internal static class ExtensionChild
    {
        //extension function's class must be at top level
        internal static void Write(this ExtensionParent ep)
        {
            Console.WriteLine("I am an extension to ExtensionParent class");
        }
    }
}
