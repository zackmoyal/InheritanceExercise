using System;

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
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            //bird object
            Bird myBird = new Bird("parrot", 3, true, "Daisy", true, 18, "blue", true);

            //display the Bird class member values
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Description of my bird:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");

            Console.WriteLine($"There is a {myBird.Species}. Her name is {myBird.Name}. {myBird.Name} is {myBird.Age} years old.");
            Console.WriteLine("");

            Console.WriteLine($"Does {myBird.Name} have a tail?");
            Console.WriteLine($"{myBird.HasTail}");
            Console.WriteLine("");

            Console.WriteLine($"Can {myBird.Name} fly?");
            Console.WriteLine($"{myBird.CanFly}");
            Console.WriteLine("");

            Console.WriteLine($"Does {myBird.Name} have a sharp break?");
            Console.WriteLine($"{myBird.IsBeakSharp}");
            Console.WriteLine("");

            Console.WriteLine("How large is her wingspan?");
            Console.WriteLine($"Her wingspan is {myBird.WingSpan} inches long.");
            Console.WriteLine("");

            Console.WriteLine("What is the color of her feathers?");
            Console.WriteLine($"They are a beautiful and vibrant {myBird.FeatherColor}.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            //reptile object
            Reptile myReptile = new Reptile("bearded dragon", 7, true, "Charizard", true, true, "woodlands", 105);

            //display the Reptile class member values
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Description of my reptile:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");

            Console.WriteLine($"There is a {myReptile.Species}. His name is {myReptile.Name}. {myReptile.Name} is {myReptile.Age} years old.");
            Console.WriteLine("");

            Console.WriteLine($"Does {myReptile.Name} have a tail?");
            Console.WriteLine($"{myReptile.HasTail}");
            Console.WriteLine("");

            Console.WriteLine("Is he cold blooded?");
            Console.WriteLine($"{myReptile.IsColdBlooded}");
            Console.WriteLine("");

            Console.WriteLine("Does he have scales?");
            Console.WriteLine($"{myReptile.HasScales}");
            Console.WriteLine("");

            Console.WriteLine($"What kind of environment could I find {myReptile.Name} living in if he were in the wild?");
            Console.WriteLine($"You would find him living in the {myReptile.Environment}.");
            Console.WriteLine("");

            Console.WriteLine($"What is his preferred temperature choice?");
            Console.WriteLine($"He would prefer to enjoy his days in weather that is around {myReptile.PreferredTemperature} degrees Fahrenheit.");


        }
    }
}
