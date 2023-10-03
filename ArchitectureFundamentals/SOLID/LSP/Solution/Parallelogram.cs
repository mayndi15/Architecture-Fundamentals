namespace Architecture_Fundamentals.SOLID.LSP.Solution;

public abstract class Parallelogram
{
    public double Height { get; private set; }
    public double Width { get; private set; }

    public double Area => Height * Width;

    protected Parallelogram(int height, int width)
    {
        Height = height;
        Width = width;
    }
}