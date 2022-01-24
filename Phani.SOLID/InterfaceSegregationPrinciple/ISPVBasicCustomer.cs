using System;

namespace Phani.SOLID.InterfaceSegregationPrinciple
{
    public class ISPVBasicCustomer: ISPVVoucher
    {
        public double BasicDiscount(double amount)
        {
            return 10.00 + amount;
        }

        //ISP violation as we dont need this method
        public double IntermediateDiscount(double amount)
        {
            throw new NotImplementedException();
        }

        //ISP violation as we dont need this method
        public double AdvancedDiscount(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
