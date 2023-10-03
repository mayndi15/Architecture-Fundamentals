namespace Architecture_Fundamentals.SOLID.LSP.Solution;

public class Square : Parallelogram
{
    public Square(int height, int width) : base(height, width)
    {
        if (height != width)
            throw new ArgumentException("Both sides of the square must be equal");
    }
}