using System;
using System.Collections.Generic;
using System.Text;

namespace PartialKW.Codes
{
    class PartialKW01
    {

        internal partial class Partial01
        {
            static Partial01()
            {
                Console.WriteLine("Different methods from same partial class");
            }
            string str01 = "I am from Part01.";
            internal string Method01()
            {
                return "From first part";
            }
        }

        internal partial class Partial01
        {
            internal string Method02()
            {
                return "From second part";
            }

            internal string Method03()
            {
                return str01 + " But called from second part.";
            }

        }
    }
}
