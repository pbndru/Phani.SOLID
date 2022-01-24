using System;
using Phani.SOLID.LiskovSubstitutePrinciple;

namespace Phani.SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //Before LSP
            CompanyCEO companyLevel = new CompanySecretary();
            Console.WriteLine(companyLevel.GetSalary());

            //After LSP
            Company company = new CompanyHR();
            Console.WriteLine(company.GetSalary());

            company = new CompanyExecutive();
            Console.WriteLine(company.GetSalary());
        }
    }
}
