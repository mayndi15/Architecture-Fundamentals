using Architecture_Fundamentals.SOLID.ISP.Solution.Interfaces;

namespace Architecture_Fundamentals.SOLID.ISP.Solution;

public class ProductRegistration : IProductRegistration
{
    public void Validate()
    {
        //Validate value
    }

    public void Save()
    {
        //Insert in table product
    }
}