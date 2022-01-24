namespace Phani.SOLID.InterfaceSegregationPrinciple
{
    public interface IIntermediateCustomer
    {
        double BasicDiscount(double amount);

        double IntermediateDiscount(double amount);
    }
}
