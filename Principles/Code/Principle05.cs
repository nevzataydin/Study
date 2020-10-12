using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesSOLID.Code
{
    class Principle05
    {

        /*
         High level modules should not depend on low level modules rather both should depend on abstraction. 
            Abstraction should not depend on details; rather detail should depend on abstraction.

        The most important point that you need to remember while developing real-time applications, 
        always try to keep the High-level module and Low-level module as loosely coupled as possible.

        When a class knows about the design and implementation of another class, 
        it raises the risk that if we do any changes to one class will break the other class. 
        So we must keep these high-level and low-level modules/classes loosely coupled as much as possible.
        To do that, we need to make both of them dependent on abstractions instead of knowing each other.
    
        instead of creating object in the class what we will consume
        we create object outside of class (in a factory class), and bring it to consumer class
        than use the object
         */
        static Principle05()
        {
            Console.WriteLine("Dependency Inversion");
        }

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }
        }

        public interface IEmployeeDataAccess
        {
            Employee GetEmployeeDetails(int id);
        }

        public class EmployeeDataAccess : IEmployeeDataAccess
        {
            public Employee GetEmployeeDetails(int id)
            {
                // In real time get the employee details from db
                //but here we are hardcoded the employee details
                Employee emp = new Employee()
                {
                    ID = id,
                    Name = "Pranaya",
                    Department = "IT",
                    Salary = 10000
                };
                return emp;
            }
        }

        public class DataAccessFactory
        {
            public static IEmployeeDataAccess GetEmployeeDataAccessObj()
            {
                return new EmployeeDataAccess();
            }
        }

        public class EmployeeBusinessLogic
        {
            IEmployeeDataAccess _EmployeeDataAccess;
            public EmployeeBusinessLogic()
            {
                _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
            }
            public Employee GetEmployeeDetails(int id)
            {
                return _EmployeeDataAccess.GetEmployeeDetails(id);
            }
        }


    }
}
