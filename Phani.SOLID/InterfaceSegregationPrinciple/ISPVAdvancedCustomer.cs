using System;

namespace Phani.SOLID.InterfaceSegregationPrinciple
{
    public class ISPVAdvancedCustomer : ISPVVoucher
    {
        public double BasicDiscount(double amount)
        {
            return 10.00 + amount;
        }

        public double IntermediateDiscount(double amount)
        {
            return 25.00 + amount;
        }

        public double AdvancedDiscount(double amount)
        {
            return 50.00 + amount;
        }
    }
}
