using QL_CoffeeShop_Test.Models.interfaces;
namespace QL_CoffeeShop_Test.Models.Service
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> ProductsList = new List<Product>()
        {
            new Product{Id = 1, Name = "America", Price = 25, detail = "Name product", ImageUrl ="http://index.com" },
            new Product{Id = 2, Name = "Latte", Price = 30, detail = "Name product", ImageUrl ="http://index.com" },
            new Product{Id = 3, Name = "Cappuccino", Price = 35, detail = "Name product", ImageUrl ="http://index.com" },
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return ProductsList;
        }


        public Product GetProductDetail(int id)
        {
            return ProductsList.FirstOrDefault(p => p.Id == id);
        }

        

        public IEnumerable<Product> GetTrendingProducts()
        {
            return ProductsList.Where(p => p.IsTrendingProduct);
        }
    }
}
