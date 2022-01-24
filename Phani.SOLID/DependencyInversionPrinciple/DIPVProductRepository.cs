namespace Phani.SOLID.DependencyInversionPrinciple
{
    public class DIPVProductRepository
    {
        public Product GetProductDetails(int id)
        {
            //fake details and not from DB
            return new Product
            {
                Id = id,
                Name = "HP",
                Description = "HP Laptop",
                Amount = 500.00
            };
        }
    }
}
