namespace Phani.SOLID.InterfaceSegregationPrinciple
{
    public class BasicCustomer: IBasicCustomer
    {
        public double BasicDiscount(double amount)
        {
            return 10.00 + amount;
        }
    }
}
