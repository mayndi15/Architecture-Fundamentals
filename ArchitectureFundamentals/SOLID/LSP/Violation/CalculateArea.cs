namespace Architecture_Fundamentals.SOLID.LSP.Violation;

public class CalculateArea
{
    private static void CalculateAreaRectangle(Rectangle rectangle)
    {
        Console.Clear();
        Console.WriteLine("Calculation of the area of the rectangle");
        Console.WriteLine();
        Console.WriteLine(rectangle.Height + " * " + rectangle.Width);
        Console.WriteLine();
        Console.WriteLine(rectangle.Area);
        Console.ReadKey();
    }

    public static void Calculate()
    {
        var square = new Square()
        {
            Height = 10,
            Width = 5
        };
        CalculateAreaRectangle(square);
    }
}