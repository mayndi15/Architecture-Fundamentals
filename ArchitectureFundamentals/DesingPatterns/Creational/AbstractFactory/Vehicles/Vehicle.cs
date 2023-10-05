using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;

public abstract class Vehicle
{
    public string Model { get; set; }
    public Size Size { get; set; }

    protected Vehicle(string model, Size size)
    {
        Model = model;
        Size = size;
    }
}

public class VehicleCreator
{
    public static Vehicle Create(string model, Size size)
    {
        switch (size)
        {
            case Size.Large:
                return new VehicleLarge(model, size);
            case Size.Medium:
                return new VehicleMedium(model, size);
            case Size.Small:
                return new VehicleSmall(model, size);
            default:
                throw new ApplicationException("Unknown vehicle size");
        }
    }
}