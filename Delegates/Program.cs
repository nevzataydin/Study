using Delegates.Codes;
using System;

namespace Delegates
{
    class Program
    {
        /*
            Calling methods:
	        Use object for non static
	        Use class name for static
	        Use delegate

         */
        static void Main(string[] args)
        {
            new Delegate01().Call();

            new Delegate02().Call();
        }
    }
}
