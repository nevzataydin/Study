using System;
using System.Collections.Generic;
using System.Text;

namespace PartialKW.Codes
{
    class PartialKW02
    {
        interface Interface01
        {
            string Method01();
        }

        interface Interface02
        {
            string Method02();
        }

        internal partial class Partial01 : Interface01
        {
            static Partial01()
            {
                Console.WriteLine("\nDifferent parts can be implemented with different interfaces");
            }
            public string Method01()
            {
                return "This method implemented with Interface01 to Partial01 class first part.";
            }
        }

        internal partial class Partial01 : Interface02
        {
            public string Method02()
            {
                return "This method implemented with Interface02 to Partial01 class second part.";
            }
        }
    }
}
