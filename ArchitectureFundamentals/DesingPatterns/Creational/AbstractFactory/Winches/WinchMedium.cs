using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Winches;

public class WinchMedium : Winch
{
    public WinchMedium(Size size) : base(size)
    {
    }

    public override void Help(Vehicle vehicle)
    {
        Console.WriteLine("Helping Medium Car - Model " + vehicle.Model);
    }
}