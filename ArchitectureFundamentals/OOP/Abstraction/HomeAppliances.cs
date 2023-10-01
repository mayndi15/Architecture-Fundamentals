namespace Architecture_Fundamentals.OOP.Abstraction;

public abstract class HomeAppliances
{
    private readonly string _name;
    private readonly int _voltage;

    protected HomeAppliances(string name, int voltage)
    {
        _name = name;
        _voltage = voltage;
    }

    public abstract void On();
    public abstract void Off();

    public virtual void Test()
    {
        // TODO: Test coffee machine 
    }
}