namespace Phani.SOLID.InterfaceSegregationPrinciple
{
    public class IntermediateCustomer : IBasicCustomer, IIntermediateCustomer
    {
        public double BasicDiscount(double amount)
        {
            return 10.00 + amount;
        }

        public double IntermediateDiscount(double amount)
        {
            return 25.00 + amount;
        }
    }
}
