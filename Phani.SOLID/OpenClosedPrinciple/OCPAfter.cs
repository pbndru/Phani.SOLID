namespace Phani.SOLID.OpenClosedPrinciple
{
    public class OCPAfter
    {
        public double GetProductDiscount(double amount, IProductDiscount productDiscount)
        {
            return productDiscount.GetDiscount(amount);
        }
    }
}
