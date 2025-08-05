﻿using System;

namespace DCIT318_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a Program to Run:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.Write("Enter your choice (1-3): ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GradeCalculator();
                    break;
                case "2":
                    TicketPriceCalculator();
                    break;
                case "3":
                    TriangleTypeIdentifier();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please run the program again.");
                    break;
            }
        }

        // Task 1: Grade Calculator
        static void GradeCalculator()
        {
            Console.Write("Enter numerical grade (0-100): ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
                Console.WriteLine("Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }

        // Task 2: Ticket Price Calculator
        static void TicketPriceCalculator()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 12 || age >= 65)
                Console.WriteLine("Ticket Price: GHC 7");
            else
                Console.WriteLine("Ticket Price: GHC 10");
        }

        // Task 3: Triangle Type Identifier
        static void TriangleTypeIdentifier()
        {
            Console.Write("Enter side 1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
