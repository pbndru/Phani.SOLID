namespace Phani.SOLID.OpenClosedPrinciple
{
    public class BasicDiscount : IProductDiscount
    {
        public double GetDiscount(double amount)
        {
            return amount - 10;
        }
    }
}
