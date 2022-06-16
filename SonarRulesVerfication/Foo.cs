namespace SonarRulesVerfication;

public abstract class Animal //Noncompliant; should be an interface
{
    public abstract void Move();
    public abstract void Feed();
}

public abstract class Color //Noncompliant; should be concrete with a private constructor
{
    private int red = 0;
    private int green = 0;
    private int blue = 0;

    public int GetRed()
    {
        return red;
    }
    public int GetGreen()
    {
        return green;
    }
    public int GetBlue()
    {
        return blue;
    }
}