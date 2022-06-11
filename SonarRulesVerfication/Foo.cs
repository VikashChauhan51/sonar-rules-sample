

namespace SonarRulesVerfication;

public class Foo
{
    private const string Foobar = "foobar";

    public string DefaultName { get; } = Foobar;


    public Foo(string value = Foobar) 
    {
        var something = value ?? Foobar; 
    }
}
