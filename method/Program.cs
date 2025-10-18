using System;

namespace MethodDemo
{
    // This class demonstrates a method with two integer parameters
    public class Calculator
    {
        // This method performs addition on the first parameter and displays the second parameter
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Add 10 to the first number and store the result
            int result = firstNumber + 10;
            
            // Display both the calculation result and the second parameter
            Console.WriteLine($"First number {firstNumber} + 10 = {result}");
            Console.WriteLine($"Second number is: {secondNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class
            Calculator calc = new Calculator();

            // Call the method using positional parameters
            Console.WriteLine("Calling method with positional parameters:");
            calc.ProcessNumbers(5, 10);

            Console.WriteLine("\nCalling method with named parameters:");
            // Call the method using named parameters
            calc.ProcessNumbers(firstNumber: 15, secondNumber: 20);

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}