using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThread.Codes
{
    //	If function needs parameters, we must use delegate to pass
    // Function can have one parameter and its type must be Object. So its not typesafe
    //Send parameter as a function's class' variable to make them type safe (like int01 and int 02 in the examples

    class MultiThread03
    {
        static MultiThread03()
        {
            Console.WriteLine("\nParameterized. Parameters must be Object type");
        }

        int int01 = 0;
        int int02 = 0;
        void Method01(object startNumber01)
        {
            int01 = (int)startNumber01;
            while (int01 < (int)startNumber01 + 1000000)
            {
                int01++;
            }
            Console.WriteLine("int01 = {0}", int01);
            Console.WriteLine("int02 = {0}", int02);
        }

        void Method02(object  startNumbers)
        {
            var numbers = (M02Numbers)startNumbers;
            int02 = numbers.startNumber02;
            while (int02 < numbers.startNumber02 + 1000000)
            {
                int02++;
                if (int01 == numbers.startNumber01 + 1000000)
                    break;
            }
        }

        internal void Call()
        {
            Thread T1 = new Thread(Method01);
            Thread T2 = new Thread(Method02);
            T1.Start(500000);
            T2.Start(new M02Numbers(600000, 500000));

            /*
             * above example is shorthand for belowe example
             * compiler convert above code to belowe
             * 
             	ParameterizedThreadStart parameterizedThreadStart =
		        new ParameterizedThreadStart(Class.FunctionName);
		        Thread T1 = new Thread(parameterizedThreadStart);
		        T1.Start(parameter);

             */
        }

        class M02Numbers
        {
            public int startNumber02 { get; set; }
            public int startNumber01 { get; set; }
            internal M02Numbers(int _startNumber02, int _startNumber01)
            {
                startNumber02 = _startNumber02;
                startNumber01 = _startNumber01;
            }
        }
    }
}
