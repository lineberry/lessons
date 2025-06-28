
namespace Lessons.Chapters.Variables;

    // A simple tutorial class introducing variables in C#
public class VariableLesson1
{
    //Method or Function depending on your terminology
    // This method demonstrates variable declaration and assignment
    // It shows how to declare a variable, assign a value, and change it later
    // It also demonstrates how to declare and change a string variable
    public static void L1()
    {
        // Declaring a variable and assigning a vacdlue
        int number = 10;
        Console.WriteLine("Initial value of number: " + number);

        // Changing the value of the variable
        number = 20;
        Console.WriteLine("New value of number: " + number);

        // Declaring and changing a string variable
        string message = "Hello";
        Console.WriteLine("Initial message: " + message);

        message = "Welcome to the variable tutorial!";
        Console.WriteLine("Updated message: " + message);
    }
}