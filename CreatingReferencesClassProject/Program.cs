// Using Class Method and passing references to objects
using System;

namespace CreatingReferencesClassProject
{
    class Triangle
    {
        public int side, altitude;
        // No defining constructor

        // Method to calculate
        // area of the triangle.
        public double Area()
        {
            return (double)0.5 * side * altitude;
        }
    }

    // Main drive class
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object using
            // new, calls the default
            // constructor
            Triangle tri1 = new Triangle();

            // create only a reference of 
            // type Triangle
            Triangle tri2;

            // Display area of tri1
            Console.WriteLine($"Area of tri1 is {tri1.Area()}");

            // Assign the reference to tri1
            tri2 = tri1;

            // Making change in tri2
            tri2.side = 5;
            tri2.altitude = 7;

            // Here is the reference changes
            // Displaying are of tri1
            // Changes made in the refernce tri2
            // are reflected in tri1 also
            Console.WriteLine($"Area of tri1 is now {tri1.Area()} through reference to tri2");

        }
    }
}
