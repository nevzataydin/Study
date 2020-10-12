using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Codes
{
    class Constructor02
    {
        //parameterized constructor
        internal Constructor02(string parameter)
        {
            Console.WriteLine(parameter);
        }

        internal Constructor02(string parameter, string parameter02)
        {
            Console.WriteLine(parameter + " " + parameter02);
        }
    }
}
