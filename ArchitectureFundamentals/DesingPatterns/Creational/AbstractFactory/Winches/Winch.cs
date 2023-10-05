using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Enum;
using Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Vehicles;

namespace Architecture_Fundamentals.DesingPatterns.Creational.AbstractFactory.Winches;

public abstract class Winch
{
    public Size Size { get; set; }

    public abstract void Help(Vehicle vehicle);

    protected Winch(Size size)
    {
        Size = size;
    }
}

public class WinchCreator
{
    public static Winch Create(Size size)
    {
        switch (size)
        {
            case Size.Large:
                return new WinchLarge(size);
            case Size.Medium:
                return new WinchMedium(size);
            case Size.Small:
                return new WinchSmall(size);
            default:
                throw new ApplicationException("Unknown winch size");
        }
    }
}