using QL_CoffeeShop_Test.Models.interfaces;
using Microsoft.AspNetCore.Mvc;
namespace QL_CoffeeShop_Test.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult shop()
        {
            return View(productRepository.GetAllProducts());
        }
    }
}
