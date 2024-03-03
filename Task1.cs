﻿/*Task 1
Build a simple calculator using Visual C sharp Programming language.
In this task, you are to build a program that receives two inputs and displays the addition, subtraction, multiplication, and division on the console.
 */
using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Perform the calculations.
            double sum = num1 + num2;
            double diff = num1 - num2;
            double product = num1 * num2;
            double quotient = num1 / num2;

            // Display the results.
            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.WriteLine($"{num1} - {num2} = {diff}");
            Console.WriteLine($"{num1} * {num2} = {product}");
            Console.WriteLine($"{num1} / {num2} = {quotient}");

            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the calculator console app...");
            Console.ReadKey();
        }
    }
}
