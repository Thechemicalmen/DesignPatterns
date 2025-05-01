namespace RepositoryPattern
{
    public interface IProductRepository : IReadProductRepository, IWriteProductRepository
    {
    }

    public interface IReadProductRepository
    {
        IReadOnlyList<Product> GetProductsInStock();
    }

    public interface IWriteProductRepository
    {
        void AddProductInStock(Product product);
        void DeleteProductFromStock(Product product);
    }
}