namespace Phani.SOLID.LiskovSubstitutePrinciple
{
    public abstract class Company
    {
        public abstract double GetSalary();
    }

    public class CompanyHR: Company
    {
        public override double GetSalary()
        {
            return 300.00;
        }
    }

    public class CompanyExecutive : Company
    {
        public override double GetSalary()
        {
            return 700.00;
        }
    }
}
