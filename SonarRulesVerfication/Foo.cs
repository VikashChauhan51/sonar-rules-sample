namespace SonarRulesVerfication;

public class Foo
{

    public Foo()
    {


        if (BooleanMethod()) { Console.WriteLine("Hello!"); } 
        if (BooleanMethod()){ /* ... */ } 

    }

    static bool BooleanMethod()
    {
        return false;
    }
}
