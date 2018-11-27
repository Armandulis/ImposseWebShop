using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WebShop.Core.DomainService;
using WebShop.Core.Entity;

namespace WebShop.Core.ApplicationService.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository productRepository)
        {
            _repo = productRepository;
        }

        public Product CreateProduct(Product product)
        {
            return _repo.CreateProduct(product);
        }

        public Product DeleteProduct(int id)
        {
            return _repo.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _repo.GetAllProducts().ToList();
        }

        public Product GetProductById(int id)
        {
            return _repo.GetAllProducts().FirstOrDefault(p => p.Id == id);
        }

        public Product UpdateProduct(Product product)
        {
            return _repo.UpdateProduct(product);
        }
    }
}
