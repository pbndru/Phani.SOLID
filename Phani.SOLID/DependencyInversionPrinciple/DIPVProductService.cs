namespace Phani.SOLID.DependencyInversionPrinciple
{
    public class DIPVProductService
    {
        private readonly DIPVProductRepository _productRepository;

        public DIPVProductService()
        {
            _productRepository = new DIPVProductRepository();
        }

        public Product GetProductDetails(int id)
        {
            return _productRepository.GetProductDetails(id);
        }
    }
}
