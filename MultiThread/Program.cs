using MultiThread.Codes;
using System;
using System.Threading;

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            new MultiThread01().Call();
            Thread.Sleep(100);

            new MultiThread02().Call();
            Thread.Sleep(100);

            new MultiThread02().Call2();
            Thread.Sleep(100);

            new MultiThread02().Call3();
            Thread.Sleep(100);

            new MultiThread03().Call();
            Thread.Sleep(100);
        }
    }
}
