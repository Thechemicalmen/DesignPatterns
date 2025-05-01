namespace RepositoryPattern
{
    public class InMemoryProductRepository : IProductRepository
    {
        public void AddProductInStock(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductFromStock(Product product)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Product> GetProductsInStock()
        {
            throw new NotImplementedException();
        }
    }
}