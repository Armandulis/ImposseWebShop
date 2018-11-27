using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Core.DomainService
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        Product DeleteProduct(int id);
    }
}
