namespace Phani.SOLID.DependencyInversionPrinciple
{
    public class ProductRepository: IProductRepository
    {
        public Product GetProductDetails(int id)
        {
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
