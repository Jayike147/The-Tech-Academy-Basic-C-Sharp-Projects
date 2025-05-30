using System;

// The Employee class implements the IQuittable interface
public class Employee : IQuittable
{
    // Properties of the Employee
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implementation of the Quit method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit his job, and is considering other options at this time.");
    }
}
