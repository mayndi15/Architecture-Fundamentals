using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Winches;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory;

public class AutoHelp
{
    private readonly Vehicle _vehicle;
    private readonly Winch _winch;


    public AutoHelp(AutoHelpFactory factory, Vehicle vehicle)
    {
        _vehicle = factory.CreateVehicle(vehicle.Model, vehicle.Size);
        _winch = factory.CreateWinch();
    }

    public void CarryOutService()
    {
        _winch.Help(_vehicle);
    }

    public static AutoHelp Create(Vehicle vehicle)
    {
        switch (vehicle.Size)
        {
            case Size.Large:
                return new AutoHelp(new LargeVehicleHelp(), vehicle);
            case Size.Medium:
                return new AutoHelp(new MediumVehicleHelp(), vehicle);
            case Size.Small:
                return new AutoHelp(new SmallVehicleHelp(), vehicle);
            default:
                throw new ApplicationException("Unable to identify vehicle");
        }
    }
}