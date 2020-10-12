using PrinciplesIoC.Codes;
using System;

namespace PrinciplesIoC
{
    class Program
    {
        /*
         LEVEL 3: PRINCIPLES
            -Inversion of Controls (IoC)
            -Dependency Inversion Principle (DIP)

        LEVEL 2: PATTERN
            -Dependency Injection

        LEVEL 1: FRAMEWORK
            -IoC Container


        IoC: IoC is a design principle which recommends the inversion of different kinds of controls 
        in object-oriented design to achieve loose coupling between application classes.

        DIP: DIP suggests that high-level modules should not depend on low level modules. 
        Both should depend on abstraction.
        A high-level module is a module which depends on other modules.

        DI:
            Constructor Injection: In the constructor injection, the injector supplies the service (dependency) 
        through the client class constructor.
            Property Injection: In the property injection (aka the Setter Injection), the injector supplies 
        the dependency through a public property of the client class.
            Method Injection: In this type of injection, the client class implements an interface which declares 
        the method(s) to supply the dependency and the injector uses this interface to supply the dependency 
        to the client class.

        IoC Container: The IoC container is a framework used to manage automatic dependency injection 
        throughout the application, so that we as programmers do not need to put more time and effort 
        into it. There are various IoC Containers for .NET, such as Unity, Ninject, StructureMap, 
        Autofac, etc. We will learn more about this in the IoC Container chapter.

        STEPS:
        1) Tightly coupled classes
        2) Implement IoC using Factory Pattern
        3) Implement DIP by creating Abstraction
        4) Implement ID
        5) Use IoC Container
        Result: Loosely coupled classes

         */
        static void Main(string[] args)
        {
            Console.WriteLine(new IoC02.CustomerService().GetCustomerName(3));
        }
    }
}
