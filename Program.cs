namespace Lessons.Chapters;

class Program
{
    static void Main(string[] args)
    {
        #region Access Modifiers

        var accessExample = new AccessModifiers.AccessExample();
        accessExample.ShowFields();

        var derivedExample = new AccessModifiers.DerivedExample();
        derivedExample.ShowInheritedFields();

        #endregion


        #region Variables

        // Lesson 1 - Introduction to Variables
        Variables.VariableLesson1.L1();

        //Lesson 2 - Static Variables
        Console.WriteLine("Static variable number in VariableTutorial2: " + Variables.VariableLesson2.lesson2StaticVariable);

        #endregion

        #region Classes

        // Lesson 1 - Introduction to Classes
        Classes.ClassesLesson1.L1();
        
        #endregion

        #region Methods
        #endregion

        #region Methods
        #endregion

        #region Conditionals
        #endregion

        #region Loops
        #endregion
    }
}
