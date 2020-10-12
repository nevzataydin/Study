using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Codes
{
    /*
     Dependency Injection (DI) is a software design pattern that allows us 
    to develop loosely coupled code. DI enables you to manage your code 
    future changes and other complexity in a better way.
    */
    /*
     The Dependency Injection pattern involves 3 types of classes.

Client Class: The client class (dependent class) is a class which depends on the service class
Service Class: The service class (dependency) is a class that provides service to the client class.
Injector Class: The injector class injects the service class object into the client class.
     */

    /*
     As you can see, the injector class creates an object of the service class, 
    and injects that object to a client object. In this way, 
    the DI pattern separates the responsibility of creating an object of the service class 
    out of the client class.
     */

    /*
    Constructor Injection: In the constructor injection, 
    the injector supplies the service (dependency) through the client class constructor.

    Property Injection: In the property injection (aka the Setter Injection), 
    the injector supplies the dependency through a public property of the client class.

    Method Injection: In this type of injection, 
    the client class implements an interface which declares the method(s) 
    to supply the dependency and the injector uses this interface 
    to supply the dependency to the client class.
     */

    class Design01
    {
    }
}
