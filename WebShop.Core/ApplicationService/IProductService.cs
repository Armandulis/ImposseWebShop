using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Core.ApplicationService
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        Product GetProductById(int id);

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        Product DeleteProduct(int id);
    }
}
