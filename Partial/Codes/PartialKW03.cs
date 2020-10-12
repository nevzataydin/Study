using System;
using System.Collections.Generic;
using System.Text;

namespace PartialKW.Codes
{
    class PartialKW03
    {
        /*
            1. Partial method declarations must begin with the partial keyword.
	        2. The return type of a partial method must be void.
	        3. Partial methods can have ref but not out parameters.
	        4. The Partial methods are implicitly private, and therefore they cannot be virtual.
	        5. Partial methods cannot be extern, because the presence of the body determines whether they are defining or implementing.
	            Can be used to customize generated code. 
	            Method name and signature are reserved
                So developer can decide whether to implement the method
         
         */


        internal partial class Partial01
        {
            static Partial01()
            {
                Console.WriteLine("\nPartial methods");
            }

            partial void Method01()
            {
                Console.WriteLine("I am first part of Method01.\nsecond part is only signature");
            }
        }

        internal partial class Partial01
        {
            partial void Method01();

            internal void Method02()
            {
                Method01();
            }

        }
    }
}
