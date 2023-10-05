using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Winches;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory;

public class SmallVehicleHelp : AutoHelpFactory
{
    public override Winch CreateWinch()
    {
        return WinchCreator.Create(Size.Small);
    }

    public override Vehicle CreateVehicle(string model, Size size)
    {
        return VehicleCreator.Create(model, size);
    }
}