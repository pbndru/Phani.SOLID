namespace Phani.SOLID.DependencyInversionPrinciple
{
    public class ProductService
    {
        //Depending on abstraction
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public Product GetProductDetails(int id)
        {
            return _productRepository.GetProductDetails(id);
        }
    }
}
