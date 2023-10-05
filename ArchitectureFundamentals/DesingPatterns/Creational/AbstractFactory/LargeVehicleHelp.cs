using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Winches;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory;

public class LargeVehicleHelp : AutoHelpFactory
{
    public override Winch CreateWinch()
    {
        return WinchCreator.Create(Size.Large);
    }

    public override Vehicle CreateVehicle(string model, Size size)
    {
        return VehicleCreator.Create(model, size);
    }
}