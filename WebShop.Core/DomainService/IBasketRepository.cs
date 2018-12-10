using WebShop.Core.Entity;

namespace WebShop.Core.DomainService
{
    public interface IBasketRepository
    {
        Basket DeleteBasket(int id);
        Basket GetBasket(int id);
        Basket NewBasket(Basket basket);
        void UpdateBasket(Basket basket, Product product = null);
        Basket GetBasketIncludeUserAndProducts(int id);
    }
}