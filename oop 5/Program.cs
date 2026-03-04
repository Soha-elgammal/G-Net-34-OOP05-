namespace oop_5
{
    #region 
    // Q1 

    //An interface in C# is a contract that defines a set of methods,
    //properties, or events without providing their implementation.
    //Any class that implements an interface must implement all its members.

    //We use interfaces instead of depending directly on concrete classes
    //to achieve abstraction and loose coupling.

    //Benefits of using interfaces:
    //1) Loose Coupling:
    //   Classes depend on abstraction instead of specific implementation,
    //   making the system flexible and easier to modify.

    //2) Polymorphism:
    //   Different classes can be treated in a unified way through
    //   the same interface type.

    //3) Multiple Inheritance:
    //   C# does not support multiple class inheritance,
    //   but a class can implement multiple interfaces.

    //4) Better Testability:
    //   Interfaces make it easier to create mock objects for unit testing.




    // ============================================
    // Q2 Answer

    //a) Problem:
    //   Both interfaces (IEnglishSpeaker and IArabicSpeaker)
    //   contain a method with the same signature: Greet().

    //   The class currently provides ONE public implementation:

    //       public void Greet()
    //       {
    //           Console.WriteLine("Hello / Ahlan");
    //       }

    //   So both interfaces share the same implementation.
    //   There is no separate behavior for each interface.

    //b) Fix:
    //   We use Explicit Interface Implementation
    //   to provide separate implementations for each interface.

    //   Example:

    //   class Translator : IEnglishSpeaker, IArabicSpeaker
    //   {
    //       void IEnglishSpeaker.Greet()
    //       {
    //           Console.WriteLine("Hello");
    //       }

    //       void IArabicSpeaker.Greet()
    //       {
    //           Console.WriteLine("Ahlan");
    //       }
    //   }

    //   This technique is called:
    //   Explicit Interface Implementation.

    //c) After using explicit implementation:

    //   We CANNOT call:
    //       translator.Greet();

    //   Because the methods are not public in the class itself.
    //   They are accessible only through the interface reference.

    //   Correct way:

    //       Translator t = new Translator();

    //       ((IEnglishSpeaker)t).Greet();
    //       ((IArabicSpeaker)t).Greet();


    // ============================================
    // Q3 Answer
    
    //Shallow Copy:
    //Copies value-type fields normally,
    //but reference-type fields copy only the reference,
    //not the actual object.

    //Deep Copy:
    //Copies both value types and reference types completely.
    //A new object is created for referenced fields.

    //When to use:

    //- Shallow copy:
    //  When the object contains only value types
    //  or shared references are acceptable.

    //- Deep copy:
    //  When you need a fully independent object
    //  and changes in the copy should NOT affect the original.

    //Risk of shallow copy:
    //If the object contains reference-type fields,
    //both objects will point to the same internal object.
    //So changing it in one object affects the other.
    


    // ============================================
    // Q4 Answer
    //Output:

    //Dev - Testing
    //QA - Testing

    //Explanation:

    //Title is a string (value copied).
    //So changing e2.Title does NOT affect e1.Title.

    //Dept is a reference type.
    //ShallowCopy copies the reference only,
    //so both e1 and e2 refer to the same Department object.

    //When we change:
    //    e2.Dept.Name = "Testing";

    //It affects the same Department object used by e1.
    //So e1.Dept.Name becomes "Testing" too.
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
