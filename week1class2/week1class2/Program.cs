using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1class2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - First and last name
            /*
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            // String concantination
            Console.WriteLine("\n" + firstName + " " + lastName);

            // Replacement method
            Console.WriteLine("{0} {1}", firstName, lastName);

            // Dollar sign method
            Console.WriteLine($"{firstName} {lastName}");
            Console.ReadLine();
            */



            // Task 2 - Name, address, age, email, 4 digit pin
            /*
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please enter your full name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your address: ");
            string address = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Please enter a four digit pin: ");
            int pin = int.Parse(Console.ReadLine());


            Console.WriteLine("\nThank you, we have recorded your details as following:");
            Console.WriteLine("Name:    " + name);
            Console.WriteLine("Address: " + address);

            Console.WriteLine("Age:     " + age);
            Console.WriteLine("Email:   " + email);
            Console.WriteLine("Pin:     " + pin);

            Console.ReadLine();
            */

            // Task 3 - 2 whole numbers, 2 decimal points, 2 strings
            Console.WriteLine("Q1. Please enter two numbers from 1-9. Press enter after each number.");
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQ2. Enter the decimal form of 1/2 and 1/4. Press enter after each number.");
            decimal dec1 = decimal.Parse(Console.ReadLine());
            decimal dec2 = decimal.Parse(Console.ReadLine());

            Console.Write("\nQ3. Enter your favorite colour: ");
            string colour = Console.ReadLine();
            Console.Write("Q4 Enter your favorite animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("\nNumbers chosen for Q1: {0}, {1}", int1, int2);
            Console.WriteLine("Numbers chosen for Q2: {0}, {1}", dec1, dec2);
            Console.WriteLine("Favorite Colour: " + colour);
            Console.WriteLine("Favorite Animal: " + animal);

            Console.ReadLine();
            

        }
    }
}
