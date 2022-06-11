

namespace SonarRulesVerfication;

public class Foo
{

    public Foo()
    {


        if (BooleanMethod() == true) { Console.WriteLine("Hello!"); } // Noncompliant
        if (BooleanMethod() == false) { /* ... */ } // Noncompliant

    }

    static bool BooleanMethod()
    {
        return false;
    }
}
