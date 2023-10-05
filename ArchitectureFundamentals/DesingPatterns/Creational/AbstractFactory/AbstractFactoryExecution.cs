using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory;

public class AbstractFactoryExecution
{
    public static void Execute()
    {
        var helpedVehicle = new List<Vehicle>()
        {
            VehicleCreator.Create("Celta", Size.Small),
            VehicleCreator.Create("Corsa", Size.Medium),
            VehicleCreator.Create("Saveiro", Size.Large),
        };

        helpedVehicle.ForEach(v => AutoHelp.Create(v).CarryOutService());
    }
}