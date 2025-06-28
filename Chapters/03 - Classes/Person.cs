namespace Lessons.Chapters.Classes;

public class Person
{
    // Fields (data about the person)
    public string Name;
    public int Age;

    // Constructor (special method to create a Person)
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method (action the person can do)
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}