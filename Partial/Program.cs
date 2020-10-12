using PartialKW.Codes;
using System;
using static PartialKW.Codes.PartialKW05;

namespace PartialKW
{
    class Program
    {

        /*
            1. All the parts must use the partial keyword.
            2. The final class is the combination of all the parts at compile time.
            3. All the parts must be available at compile time to form the final class.
            4. Any class members declared in a partial definition are available to all the other parts. 
            5. All the parts must have the same access modifiers – public, private, protected, etc.
       
	        Yes
		        Class
		        Struct
		        Interface
		        Method
	        No
		        Delegate
		        Enumeration

         */
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var partial01 = new PartialKW01.Partial01();
            Console.WriteLine(partial01.Method01());
            Console.WriteLine(partial01.Method02());
            Console.WriteLine(partial01.Method03());


            var partial02 = new PartialKW02.Partial01();
            Console.WriteLine(partial02.Method01());
            Console.WriteLine(partial02.Method02());


            new PartialKW03.Partial01().Method02();


            var partial04 = new PartialKW04.Partial01();
            Console.WriteLine(partial04.Method01());
            Console.WriteLine(partial04.Method02());

            Console.WriteLine("\nPartial Struct");
            Struct01 p = new Struct01(6, 5);
            Console.WriteLine($"({p.X}, {p.Y})");  // output: (3, 4)
        }
    }
}
