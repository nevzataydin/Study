using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Codes
{
    /*
     	User defined
		So before calling a method with delegate, you must define delegate first.
		It is type safe: holds the reference of the method.
		Function and its delegate's signatures match
		Its like class: 
			we create an instance of it.  
			Pass function's name as a parameter to delegate constructor
			So delegate points to that function

     */
    delegate int NumberChangerDelegate(int n);
    delegate int NumberGetDelegate();
    class Delegate01
    {
        static int num = 10;

        static Delegate01()
        {
            Console.WriteLine(@"Lambda Expression: Is a short hand for delegates
Single Cast: Basic delegate call (Instantiating) with and without parameters");
        }

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }

        internal void Call()
        {
            NumberChangerDelegate ncAdd = new NumberChangerDelegate(AddNum);
            NumberChangerDelegate ncMult = new NumberChangerDelegate(MultNum);
            NumberGetDelegate nGet = new NumberGetDelegate(GetNum);

            //calling the methods using the delegate objects
            ncAdd(25);
            Console.WriteLine("add 10 + '25': {0}", nGet());
            ncMult(5);
            Console.WriteLine("multi 15 * '5': {0}", nGet());
        }
    }
}
