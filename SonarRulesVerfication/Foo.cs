

namespace SonarRulesVerfication;

public class Foo
{
    private string name = "foobar"; // Noncompliant

    public string DefaultName { get; } = "foobar"; // Noncompliant

    public Foo(string value = "foobar") // Noncompliant
    {
        var something = value ?? "foobar"; // Noncompliant
    }
}
