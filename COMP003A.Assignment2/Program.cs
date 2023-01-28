/*
 * Author: Steven Gonzalez
 * Course: Comp-3A
 * Purpose: Consol aection, String section, Math section and Circle Area & Circumference Calculator Section
 */

using System.Reflection;

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] arge)
        {
            Console.Title = "COMP-003A - Assignment 2";

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("**************************************************");
            Console.WriteLine("Consol section");
            Console.WriteLine("**************************************************");

            Console.WriteLine("");

            Console.WriteLine("**************************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("**************************************************");
          
            string firstName;
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
           
            string middleName; Console.WriteLine("Enter Middle Name: ");
            middleName = Console.ReadLine();


            string lastName;
            Console.WriteLine("Enter Last Name: ");
            lastName = Console.ReadLine();

            string inputAge;
            Console.WriteLine($"Enter age in 2023: ");
            inputAge = Console.ReadLine();

            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            Console.WriteLine("");

            Console.WriteLine("**************************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("**************************************************");

            string integer1;
            Console.WriteLine($"Enter an integer for integer1: "); integer1 = Console.ReadLine();



            string integer2;
            Console.WriteLine($"Enter an integer for integer2: "); integer2 = Console.ReadLine();

            int integer = Convert.ToInt32(integer1) + Convert.ToInt32(integer2);
            int Integer = Convert.ToInt32(integer1) - Convert.ToInt32(integer2);
            int INteger = Convert.ToInt32(integer1) * Convert.ToInt32(integer2);
            int INTeger = Convert.ToInt32(integer1) / Convert.ToInt32(integer2);
            int INTEger = Convert.ToInt32(integer1) % Convert.ToInt32(integer2);

            Console.WriteLine($"{integer1} + {integer2} = {integer}");
            Console.WriteLine($"{integer1} - {integer2} = {Integer}");
            Console.WriteLine($"{integer1} * {integer2} = {INteger}");
            Console.WriteLine($"{integer1} / {integer2} = {INTeger}");
            Console.WriteLine($"{integer1} % {integer2} = {INTEger}");

            Console.WriteLine("");

            Console.WriteLine("**************************************************");
            Console.WriteLine("Circle Area & Circumference Calculator Section");
            Console.WriteLine("**************************************************");



            string radius; 
            Console.WriteLine($"Enter radius: "); radius = Console.ReadLine();


            double area = Math.PI * Convert.ToDouble(radius) * Convert.ToDouble(radius);

            Console.WriteLine($" The area is {area}");

            double circumference = 2 * Math.PI * Convert.ToDouble(radius);

            Console.WriteLine($" The circumference is {circumference}");
        }
    }
}

