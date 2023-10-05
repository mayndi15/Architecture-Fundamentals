using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;

public class VehicleMedium : Vehicle
{
    public VehicleMedium(string model, Size size) : base(model, size)
    {
    }
}