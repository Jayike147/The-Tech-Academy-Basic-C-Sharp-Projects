Using System;

Namespace EmployeeComparisonApp
{
    Class Program
    {
        Static void Main(String[] args)
        {
            // Create the first Employee object And set its properties
            Employee employee1 = New Employee
            {
                Id = 101,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Create the second Employee object with a different ID
            Employee employee2 = New Employee
            {
                Id = 102,
                FirstName = "Bob",
                LastName = "Smith"
            };

            // Compare the two employees using the overloaded '==' operator
            bool areEqual = employee1 == employee2;

            // Display the result of the comparison
            Console.WriteLine("Are employee1 and employee2 equal by Id? " + areEqual);

            // Create a third Employee with the same ID as the first
            Employee employee3 = New Employee
            {
                Id = 101,
                FirstName = "Charlie",
                LastName = "Brown"
            };

            // Compare employee1 And employee3
            Console.WriteLine("Are employee1 and employee3 equal by Id? " + (employee1 == employee3));

            // Keep the console open
            Console.ReadKey();
        }
    }
}
