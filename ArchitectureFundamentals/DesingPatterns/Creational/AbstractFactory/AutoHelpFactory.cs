using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Winches;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory;

public abstract class AutoHelpFactory
{
    public abstract Winch CreateWinch();
    public abstract Vehicle CreateVehicle(string model, Size size);
}