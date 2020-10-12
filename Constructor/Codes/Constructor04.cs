using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Codes
{
    /*
     	4. Static Constructor: constructory has static keyword. Constructor initialize only once, once the first instance of that class is initialized.
		    a. There can be only one static constructor in a class.
		    b. The static constructor should be without any parameter.
		    c. It can only access the static members of the class.
		    d. There should not be any access modifier in static constructor definition.
		    e. If a class is static then we cannot create the object for the static class.
		    f. Static constructor will be invoked only once i.e. at the time of first object creation of the class, 
                from 2nd object creation onwards static constructor will not be called.

     */
    class Constructor04
    {
        static Constructor04()
        {
            Console.WriteLine(str01);
        }

        static string str01 = "\nI am a static constructor. I can be called only once.";
    }
}
