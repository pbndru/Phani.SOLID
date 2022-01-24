namespace Phani.SOLID.LiskovSubstitutePrinciple
{
    public class CompanyCEO
    {
        public virtual double GetSalary()
        {
            return 1000.00;
        }
    }

    public class CompanySecretary: CompanyCEO
    {
        public override double GetSalary()
        {
            return 800.00;
        }
    }
}
