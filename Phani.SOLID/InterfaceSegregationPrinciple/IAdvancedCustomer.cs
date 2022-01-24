namespace Phani.SOLID.InterfaceSegregationPrinciple
{
    public interface IAdvancedCustomer
    {
        double BasicDiscount(double amount);

        double IntermediateDiscount(double amount);

        double AdvancedDiscount(double amount);
    }
}
