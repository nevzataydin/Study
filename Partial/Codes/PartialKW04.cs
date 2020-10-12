using System;
using System.Collections.Generic;
using System.Text;

namespace PartialKW.Codes
{
    class PartialKW04
    {
        partial interface Interface01
        {
            string Method01();
        }

        partial interface Interface01
        {
            string Method02();
        }

        internal class Partial01 : Interface01
        {
            static Partial01()
            {
                Console.WriteLine("\nPartial Interface");
            }
            public string Method01()
            {
                return "I am implemented with the first part of interface";
            }

            public string Method02()
            {
                return "I am implemented with the second part of interface";
            }
        }
    }
}
