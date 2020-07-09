using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your 



            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             


             * 
             * Creatively display the class member values 
             */

            Bird falcon = new Bird()
            {
                NumberOfLegs = 2,
                Age = 5,
                CanFly = true,
                FeatherColor = "Black",
                Diet = "Snakes and Mice",
                Gender = "Female",
                BeakType = "Meat Eater"
            };


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             
             * 
             * Creatively display the class member values 
             */
            Reptile rep = new Reptile()
            {
                Age = 1,
                CanFly = false,
                CanChangeColors = true,
                Diet = "Chicken Eggs",
                Gender = "Male",
                NumberOfLegs = 0,
                ScaleType = "Smooth",
                TailLength = 2.3
            };


            List<Animal> animals = new List<Animal> ();
            animals.Add(rep);
            animals.Add(falcon); 


            foreach(Animal myAnimal in animals)
            {
             Console.WriteLine($"This type of animal is a {myAnimal.GetType().Name}it eats:{myAnimal.Diet}" +
             $"the gender is:{myAnimal.Gender}it has {myAnimal.NumberOfLegs}legs, and lastly can it fly?" +
             $"That is a {myAnimal.CanFly}statement!");                 }


            }
        
            
            
                
          }

           
        }
    
             