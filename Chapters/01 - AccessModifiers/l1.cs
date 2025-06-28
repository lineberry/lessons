using System;

namespace Lessons.Chapters.AccessModifiers;

public class AccessExample
{
    // Public: Accessible from anywhere
    public string PublicField = "Public Field";

    // Private: Accessible only within this class
    private string PrivateField = "Private Field";

    // Protected: Accessible within this class and derived classes
    protected string ProtectedField = "Protected Field";

    // Internal: Accessible within the same assembly
    internal string InternalField = "Internal Field";

    // Protected Internal: Accessible within the same assembly or from derived classes
    protected internal string ProtectedInternalField = "Protected Internal Field";

    // Private Protected: Accessible within this class or derived classes in the same assembly
    private protected string PrivateProtectedField = "Private Protected Field";

    public void ShowFields()
    {
        Console.WriteLine(PublicField);
        Console.WriteLine(PrivateField);
        Console.WriteLine(ProtectedField);
        Console.WriteLine(InternalField);
        Console.WriteLine(ProtectedInternalField);
        Console.WriteLine(PrivateProtectedField);
    }
}

// Example of a derived class
public class DerivedExample : AccessExample
{
    public void ShowInheritedFields()
    {
        Console.WriteLine(PublicField);
        // Console.WriteLine(PrivateField); // Not accessible
        Console.WriteLine(ProtectedField);
        Console.WriteLine(InternalField);
        Console.WriteLine(ProtectedInternalField);
        Console.WriteLine(PrivateProtectedField);
    }
}