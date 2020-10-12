using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThread.Codes
{
    //we also could use delegates for parameterless methods
    class MultiThread02
    {
        static MultiThread02()
        {
            Console.WriteLine("\nUse delegate. Manual start:");
        }

        int int01 = 0;
        int int02 = 0;
        void Method01()
        {
            while (int01 <  1000000)
            {
                int01++;
            }
            Console.WriteLine("int01 = {0}", int01);
            Console.WriteLine("int02 = {0}", int02);
        }

        void Method02()
        {
            while (int02 <  1000000)
            {
                int02++;
                if (int01 == 1000000)
                    break;
            }
        }

        internal void Call()
        {
            Thread T1 = new Thread(new ThreadStart(Method01));
            Thread T2 = new Thread(new ThreadStart(Method02));
            T1.Start();
            T2.Start();
        }

        internal void Call2()
        {
            Console.WriteLine("\nUse delegate. auto start:");
            int01 = 0;
            int02 = 0;
            Thread T1 = new Thread(delegate () { Method01(); });
            Thread T2 = new Thread(delegate () { Method02(); });
            T1.Start();
            T2.Start();
        }

        internal void Call3()
        {
            Console.WriteLine("\nUse delegate. auto start lambda:");
            int01 = 0;
            int02 = 0;
            Thread T1 = new Thread( () => { Method01(); });
            Thread T2 = new Thread( () => { Method02(); });
            T1.Start();
            T2.Start();
        }
    }
}
