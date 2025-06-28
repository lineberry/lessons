namespace Lessons.Chapters.Classes;

    
public class ClassesLesson1
{
    public static void L1()
    {
        // This method demonstrates the concept of classes in C#
        // It shows how to define a class, create an instance, and use its members

        // Creating an instance of the Person class
        Person alice = new Person("Alice", 30);

        // Calling the SayHello method on the person instance
        alice.SayHello();

        Person mario = new Person("Mario", 25);
        mario.SayHello();
    }
}