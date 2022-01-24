namespace Phani.SOLID.OpenClosedPrinciple
{
    public class AdvancedDiscount : IProductDiscount
    {
        public double GetDiscount(double amount)
        {
            return amount - 50;
        }
    }
}
