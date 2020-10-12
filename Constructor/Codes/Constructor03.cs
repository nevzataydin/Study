using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Codes
{
    class Constructor03
    {
        internal Constructor03() { }

        internal Constructor03(Constructor03 constructor03)
        {
            Console.WriteLine("I am a copy constructor");
            MyProperty01 = constructor03.MyProperty01;
            MyProperty02 = constructor03.MyProperty02;
        }

        public int MyProperty01 { get; set; }
        public int MyProperty02 { get; set; }
    }
}
