namespace Phani.SOLID.OpenClosedPrinciple
{
    public class OCPBefore
    {
        public double GetProductDiscount(double amount, ProductType productType)
        {
            double discountAmount = 0;

            if (productType == ProductType.Basic)
            {
                discountAmount = amount - 10;
            }
            else if (productType == ProductType.Intermediate)
            {
                discountAmount = amount - 25;
            }
            else if (productType == ProductType.Advanced)
            {
                discountAmount = amount - 50;
            }
            return discountAmount;
        }
    }
}
