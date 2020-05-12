using Tobacco_Shop.Context;
using Tobacco_Shop.Models;
using Tobacco_Shop.Repositories;
using System;

namespace Tobacco_Shop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly Cart _cart;

        public OrderRepository(AppDbContext appDbContext, Cart cart)
        {
            _appDbContext = appDbContext;
            _cart = cart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderSend = DateTime.Now;
            //pedido.PedidoEntregueEm = DateTime.Now;

            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCarts = _cart.ShoppingCarts;

            foreach (var cartItem in shoppingCarts)
            {
                var orderDetail = new OrderDetail()
                {
                    Quantity = cartItem.Quantity,
                    TobaccoId = cartItem.Tobacco.TobaccoId,
                    OrderId = order.OrderId,
                    Price = cartItem.Tobacco.Price
                };
                _appDbContext.OrderDetails.Add(orderDetail);
            }
            _appDbContext.SaveChanges();
        }
    }
}
