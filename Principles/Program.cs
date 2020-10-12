using PrinciplesSOLID.Code;
using System;

namespace PrinciplesSOLID
{
    class Program
    {
        /*
         Single Responsibility. 
            “There should be never more than one reason for a class to change.”

        Open Closed Principle
            “Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.”
            Modifying a class behaviour must be done by extending it, not modifying it 

        Liskov Substitution Principle
            “subtypes must be substitutable for their base types”
            objects should be replaceable by instances of their subtypes

        Interface Segregation Principle
            once an interface is becoming too large, we need to split it into small interfaces that are more specific. 
        And interface will be defined by the client that will use it, which means that client of the interface will only know about the methods that are related to them.

        Dependency Inversion Principle
            High level modules should not depend on low level modules rather both should depend on abstraction. 
            Abstraction should not depend on details; rather detail should depend on abstraction.
        

        https://dotnettutorials.net/lesson/solid-design-principles/
         */
        static void Main(string[] args)
        {
            new Principle01();

            new Principle01.SingleResponsibilty().Write();

            new ExtensionParent().Write();

            new Principle03().Call();

            var principle04Cls01 = new Principle04.Cls01();
            var principle04Cls02 = new Principle04.Cls02();
            principle04Cls01.Mth01();
            principle04Cls01.Mth02();
            principle04Cls02.Mth01();

            var principle05Business = new Principle05.EmployeeBusinessLogic();
            var data = principle05Business.GetEmployeeDetails(5);
            Console.WriteLine(data.ID + " " + data.Name + " " + data.Department + " " + data.Salary);
        }
    }
}
