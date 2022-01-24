namespace Phani.SOLID.OpenClosedPrinciple
{
    public class IntermediateDiscount : IProductDiscount
    {
        public double GetDiscount(double amount)
        {
            return amount - 25;
        }
    }
}
