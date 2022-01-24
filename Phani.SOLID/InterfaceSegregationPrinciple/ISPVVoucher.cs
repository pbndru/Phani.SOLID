namespace Phani.SOLID.InterfaceSegregationPrinciple
{
    public interface ISPVVoucher
    {
        double BasicDiscount(double amount);

        double IntermediateDiscount(double amount);

        double AdvancedDiscount(double amount);
    }
}
