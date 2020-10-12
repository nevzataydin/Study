using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Codes
{
    class Polymorphism04
    {
        /*
         * operator overloading
         * 
        +, -, !, ~, ++, --
        These unary operators take one operand can be overloaded

        +, -, *, /, %
        These binary operators take two operands and can be overloaded

        ==, !=, <, >, <=, >=
        The comparison operators can be overloaded

        &&, ||
        The conditional logical operators cannot be overloaded directly and evaluated by using the & and | which can be overloaded

        +=, -=, *=, /==, %==
        The assignment operators cannot be overloaded

        =, ? :, - >, new, sizeof, typeof
        These operators cannot be overloaded
         */

        internal class Calculate
        {
            public int number1, number2;
            public Calculate(int no1, int no2)
            {
                number1 = no1;
                number2 = no2;
            }
            public Calculate()
            {
            }

            /*  
             *  on the program.cs we call "c1 = -c;"
             *  that - operation corresponds "operator -" here
             *  you can use unary and binary operations like this (refer top of this page)
            */
            public static Calculate operator - (Calculate c1)
            {
                c1.number1 = -c1.number1;
                c1.number2 = -c1.number2;
                return c1;
            }
            public void Print()
            {
                Console.WriteLine("number1 =" + number1);
                Console.WriteLine("number2 =" + number2);
                Console.WriteLine("--");
            }
        }
    }
}
