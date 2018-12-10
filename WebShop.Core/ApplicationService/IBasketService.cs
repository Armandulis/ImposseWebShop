using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Core.ApplicationService
{
    public interface IBasketService
    {
        Basket NewBasket(Basket basket);
        Basket GetBasket(int id);
        Basket AddToBasket(int id, Product product);
        void ClearBasket(int id);
        Basket DeleteBasket(int id);
        List<Product> GetProductsInBasket(int basketId);
    }
}
