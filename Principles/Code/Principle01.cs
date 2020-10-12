using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static PrinciplesSOLID.Code.Principle01;

namespace PrinciplesSOLID.Code
{
    class Principle01
    {
        static Principle01()
        {
            Console.WriteLine("SOLID");
        }

        //1
        internal class SingleResponsibilty
        {
            static SingleResponsibilty()
            {
                Console.WriteLine("\nSingle Responsibility: A class should have only one responsibility.");
            }
            internal void Write()
            {
                Console.WriteLine("My only responsibility to write to screen");
            }
        }
    }

}

