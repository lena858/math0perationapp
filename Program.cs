using System;   // Using System library to access Console methods

namespace MathOperationApp
{
    // Define a class called MathClass
    class MathClass
    {
        // Create a void method that takes two integers as parameters
        public void DoMath(int number1, int number2)
        {
            // Perform a math operation on the first number (multiply by 2)
            int result = number1 * 2;

            // Print the result of the first number
            Console.WriteLine("Result of first number * 2 = " + result);

            // Print the second number directly
            Console.WriteLine("Second number is: " + number2);
        }
    }

    // Main program
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of MathClass
            MathClass mathObj = new MathClass();

            // Call the method with two numbers directly
            mathObj.DoMath(5, 10);

            // Call the method again using named parameters
            mathObj.DoMath(number1: 7, number2: 20);

            // Keep console open until user presses Enter
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}



