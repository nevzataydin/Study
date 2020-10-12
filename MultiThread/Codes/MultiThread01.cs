using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThread.Codes
{
    class MultiThread01
    {
        static MultiThread01()
        {
            Console.WriteLine("Multi Threads without parameter");
        }
        int int01 = 0;
        int int02 = 0;
        void Method01()
        {
            while (int01 < 1000000)
            {
                int01++;
            }
            Console.WriteLine("int01 = {0}", int01);
            Console.WriteLine("int02 = {0}", int02);
        }

        void Method02()
        {
            while (int02 < 1000000)
            {
                int02++;
                if (int01 == 1000000)
                    break;
            }
        }

        Thread T2;
        internal void Call()
        {
            Thread T1 = new Thread(Method01);
            T2 = new Thread(Method02);
            T1.Start();
            T2.Start();
        }
    }
}
