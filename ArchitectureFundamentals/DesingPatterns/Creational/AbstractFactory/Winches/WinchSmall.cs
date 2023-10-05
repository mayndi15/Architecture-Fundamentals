using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Winches;

public class WinchSmall : Winch
{
    public WinchSmall(Size size) : base(size)
    {
    }

    public override void Help(Vehicle vehicle)
    {
        Console.WriteLine("Helping Small Car - Model " + vehicle.Model);
    }
}