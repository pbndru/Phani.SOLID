using System;

namespace Phani.SOLID.InterfaceSegregationPrinciple
{
    public class ISPVIntermediateCustomer : ISPVVoucher
    {
        public double BasicDiscount(double amount)
        {
            return 10.00 + amount;
        }

        public double IntermediateDiscount(double amount)
        {
            return 25.00 + amount;
        }

        //ISP violation as we dont need this method
        public double AdvancedDiscount(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
