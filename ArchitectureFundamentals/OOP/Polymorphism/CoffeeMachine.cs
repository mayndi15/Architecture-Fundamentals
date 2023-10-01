using Architecture_Fundamentals.OOP.Abstraction;

namespace Architecture_Fundamentals.OOP.Polymorphism;

public class CoffeeMachine : HomeAppliances
{
    public CoffeeMachine(string name, int voltage) : base(name, voltage)
    {
    }

    public CoffeeMachine() : base("Default", 110)
    {
    }

    public void PrepareCoffee()
    {
        Test();
        HeatWater();
        GrindGrain();
    }

    private static void HeatWater()
    {
    }

    private static void GrindGrain()
    {
    }

    public override void On()
    {
        throw new NotImplementedException();
    }

    public override void Off()
    {
        throw new NotImplementedException();
    }

    public override void Test()
    {
        throw new NotImplementedException();
    }
}