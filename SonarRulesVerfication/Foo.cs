

namespace SonarRulesVerfication;

public class Foo
{
    private const string Hello = "Hello word constant";

    public string DefaultName { get; } = "Hello word constant";


    public Foo(string value = "Hello word constant") 
    {
        var something = value ?? Hello;
        Console.WriteLine(something);
    }
}
