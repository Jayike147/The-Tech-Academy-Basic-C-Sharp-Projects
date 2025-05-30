using System;  // Import the base library

namespace QuitExample  // Match your project name here
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create an instance of the Employee class
            Employee emp = new Employee()
            {
                FirstName = "James",
                LastName = "Dogecoin"
            };

            // Step 2: Use polymorphism to assign the Employee object to an IQuittable interface reference
            IQuittable quittableEmp = emp;

            // Step 3: Call the Quit() method using the interface reference
            quittableEmp.Quit();

            // Step 4: Keep the console window open so you can see the output
            Console.ReadLine();
        }
    }
}
