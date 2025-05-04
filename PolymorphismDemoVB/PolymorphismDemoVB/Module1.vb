' Define an interface called IQuittable
Interface IQuittable
    ' Declare a method named Quit with no return value
    Sub Quit()
End Interface

' Define the Person base class
Class Person
    ' Two string properties: FirstName and LastName
    Public Property FirstName As String
    Public Property LastName As String

    ' Method to display full name
    Public Sub SayName()
        Console.WriteLine("Name: " & FirstName & " " & LastName)
    End Sub
End Class

' Define the Employee class that inherits from Person and implements IQuittable
Class Employee
    Inherits Person
    Implements IQuittable

    ' Additional property for Employee ID
    Public Property Id As Integer

    ' Implementation of the Quit method from IQuittable interface
    Public Sub Quit() Implements IQuittable.Quit
        Console.WriteLine(FirstName & " " & LastName & " has quit the job.")
    End Sub
End Class

' Main program module
Module Program
    Sub Main()
        ' Instantiate and initialize an Employee object
        Dim emp As New Employee With {
            .FirstName = "Sample",
            .LastName = "Student",
            .Id = 101
        }

        ' Call the SayName method from the base class
        emp.SayName()

        ' Use polymorphism: declare a variable of type IQuittable and assign it the employee object
        Dim quittableEmp As IQuittable = emp

        ' Call the Quit method using the interface reference
        quittableEmp.Quit()

        ' Keep the console open until a key is pressed
        Console.ReadKey()
    End Sub
End Module
