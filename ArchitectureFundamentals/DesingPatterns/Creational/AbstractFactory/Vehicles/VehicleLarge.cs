using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;

public class VehicleLarge : Vehicle
{
    public VehicleLarge(string model, Size size) : base(model, size)
    {
    }
}