namespace Phani.SOLID.DependencyInversionPrinciple
{
    public class DIPProductService
    {
        private readonly DIPVProductRepository _productRepository;

        public DIPProductService()
        {
            _productRepository = new DIPVProductRepository();
        }

        public Product GetProductDetails(int id)
        {
            return _productRepository.GetProductDetails(id);
        }
    }
}
