namespace Architecture_Fundamentals.OOP.ClassVsObject;

public class House
{
    // Class definition
    public int SizeM2 { get; set; }
    public int Floors { get; set; }
    public int Value { get; set; }
}

public class Object
{
    public Object()
    {
        // Object definition
        var house = new House
        {
            SizeM2 = 100,
            Floors = 2,
            Value = 10000
        };
    }
}