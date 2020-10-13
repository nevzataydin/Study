using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactory.Codes
{
    // abstract factory design pattern
    /*
     abstract factory pattern allowes us to choose different but relative factories,
    then allowes us to create object with that choosen factory 
     */
    class Factory02
    {
        public interface Animal
        {
            string speak();
        }

        #region Types

        public class Cat : Animal
        {
            public string speak()
            {
                return "Meow Meow Meow";
            }
        }
        public class Lion : Animal
        {
            public string speak()
            {
                return "Roar";
            }
        }
        public class Dog : Animal
        {
            public string speak()
            {
                return "Bark bark";
            }
        }
        public class Octopus : Animal
        {
            public string speak()
            {
                return "SQUAWCK";
            }
        }
        public class Shark : Animal
        {
            public string speak()
            {
                return "Cannot Speak";
            }
        }
        #endregion


        #region Abstract Factory
        public abstract class AnimalFactory
        {
            public abstract Animal GetAnimal(string AnimalType);
            public static AnimalFactory CreateAnimalFactory(string FactoryType)
            {
                if (FactoryType.Equals("Sea"))
                    return new SeaAnimalFactory();
                else
                    return new LandAnimalFactory();
            }
        }
        #endregion
        #region Factory

        public class LandAnimalFactory : AnimalFactory
        {
            public override Animal GetAnimal(string AnimalType)
            {
                if (AnimalType.Equals("Dog"))
                {
                    return new Dog();
                }
                else if (AnimalType.Equals("Cat"))
                {
                    return new Cat();
                }
                else if (AnimalType.Equals("Lion"))
                {
                    return new Lion();
                }
                else
                    return null;
            }
        }
        public class SeaAnimalFactory : AnimalFactory
        {
            public override Animal GetAnimal(string AnimalType)
            {
                if (AnimalType.Equals("Shark"))
                {
                    return new Shark();
                }
                else if (AnimalType.Equals("Octopus"))
                {
                    return new Octopus();
                }
                else
                    return null;
            }
        }
        #endregion

        internal static void Call()
        {
            Console.WriteLine("\nAbstract Factory Pattern");
            /*
            factory is created by abstract factory
            object is created by factory, via abstract factory
             */


            Animal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;

            //ABSTARCT FACTORY Create the Sea Factory object by passing the factory type as Sea
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            //FACTORY Get Octopus Animal object by passing the animal type as Octopus
            animal = animalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            Console.WriteLine("--------------------------");

            //ABSTARCT FACTORY Create Land Factory object by passing the factory type as Land
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            //FACTORY Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal("Lion");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();

            //FACTORY Get Cat Animal object by passing the animal type as Cat
            animal = animalFactory.GetAnimal("Cat");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);

        }

    }
}
