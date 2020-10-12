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
            Console.WriteLine("Multi Threads");
        }
        void Method01()
        {
            Console.WriteLine("Thread 1");
        }

        internal void Call()
        {
            Thread T1 = new Thread(Method01); 
            T1.Start();
        }
    }
}
