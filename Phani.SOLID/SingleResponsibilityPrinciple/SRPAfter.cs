using System;

namespace Phani.SOLID.SingleResponsibilityPrinciple
{
    public class SRPAfter
    {
        public void GetProduct(string productName, ProductRepository productRepository, EmailService emailService)
        {
            if (productName is null)
            {
                throw new InvalidOperationException();
            }

            productRepository.SelectProduct(productName);
            emailService.Send("Test");
        }
    }
}
