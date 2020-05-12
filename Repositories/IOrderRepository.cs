using Tobacco_Shop.Models;

namespace Tobacco_Shop.Repositories
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
