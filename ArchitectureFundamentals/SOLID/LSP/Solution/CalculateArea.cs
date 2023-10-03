namespace Architecture_Fundamentals.SOLID.LSP.Solution;

public class CalculateArea
{
    private static void CalculateAreaParallelogram(Parallelogram parallelogram)
    {
        Console.Clear();
        Console.WriteLine("Calculation of the area of the parallelogram");
        Console.WriteLine();
        Console.WriteLine(parallelogram.Height + " * " + parallelogram.Width);
        Console.WriteLine();
        Console.WriteLine(parallelogram.Area);
        Console.ReadKey();
    }

    public static void Calculate()
    {
        var square = new Square(5, 5);
        var rectangle = new Rectangle(10, 5);

        CalculateAreaParallelogram(square);
        CalculateAreaParallelogram(rectangle);
    }
}