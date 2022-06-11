

namespace SonarRulesVerfication;

public class Foo
{
    private string name = "foobar"; // Noncompliant

    private int age = 20; // Noncompliant
    private bool status = true;// Noncompliant

    private long state = 15L;// Noncompliant
    public string DefaultName { get; } = "foobar"; // Noncompliant


    public Foo(string value = "foobar") // Noncompliant
    {
        var something = value ?? "foobar"; // Noncompliant
    }
}
