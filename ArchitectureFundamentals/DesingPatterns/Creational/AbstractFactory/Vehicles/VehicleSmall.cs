using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;

public class VehicleSmall : Vehicle
{
    public VehicleSmall(string model, Size size) : base(model, size)
    {
    }
}