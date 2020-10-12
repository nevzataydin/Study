using Polymorphism.Codes;
using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01 Overriding");
            Console.WriteLine(new Polymorhpism01.Parent().Method());
            Console.WriteLine(new Polymorhpism01.Child().Method());
            Console.WriteLine(new Polymorhpism01.Child2().Method());


            Console.WriteLine("\n02 Overloading");
            Console.WriteLine(new Polymorphism02.Child().Method());
            Console.WriteLine(new Polymorphism02.Child("2").Method("2"));


            Console.WriteLine("\n03 Method Hidinig");
            Console.WriteLine(new Polymorphism03.Parent().Method());
            Console.WriteLine(new Polymorphism03.Child().Method());
            Console.WriteLine(new Polymorphism03.Child().Method2());

            Console.WriteLine("\n04 Operator Overloading");
            Polymorphism04.Calculate c = new Polymorphism04.Calculate(20, -40);
            c.Print();
            _ = new Polymorphism04.Calculate();
            Polymorphism04.Calculate c1 = -c;
            c1.Print();
        }
    }

}
