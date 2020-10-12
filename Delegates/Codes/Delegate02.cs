using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Codes
{
    class Delegate02
    {
        delegate int NumberChangerDelegate(int n);
        delegate int NumberGetDelegate();
        static int num = 10;

        static Delegate02()
        {
            Console.WriteLine(@"
Multi Cast: I / O parameters of all methods must be same
Multicast delegate makes the implementation of observer design pattern very simple. 
The observer pattern is also called a publish/subscribe pattern.
");
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
            NumberChangerDelegate ncDel;
            NumberChangerDelegate ncAdd = new NumberChangerDelegate(AddNum);
            NumberChangerDelegate ncMult = new NumberChangerDelegate(MultNum);
            NumberGetDelegate nGet = new NumberGetDelegate(GetNum);

            ncDel = ncAdd + ncMult;
            ncDel(5);

            Console.WriteLine("add then multiply (10 + '5')'5': {0}", nGet());

            ncDel = ncAdd + ncMult - ncAdd;
            ncDel(2);
            Console.WriteLine("add then multiply (75 + '2')'2' but we remove addition. so 75 * 2: {0}", nGet());

        }
    }
}
