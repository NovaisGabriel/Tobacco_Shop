using Tobacco_Shop.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tobacco_Shop.Models
{
    public class Cart
    {
        private readonly AppDbContext _context;

        public Cart(AppDbContext contextop)
        {
            _context = contextop;
        }

        public string SCartId { get; set; }
        public List<ShoppingCart> ShoppingCarts { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            ISession session =
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var contextop = services.GetService<AppDbContext>();

            string scartId = session.GetString("SCartId") ?? Guid.NewGuid().ToString();

            session.SetString("SCartId", scartId);

            return new Cart(contextop)
            {
                SCartId = scartId
            };
        }

        public void AddCart(Tobacco tobacco, int quantity)
        {
            var ShoppingCart =
                    _context.ShoppingCarts.SingleOrDefault(
                        s => s.Tobacco.TobaccoId == tobacco.TobaccoId && s.SCartId == SCartId);

            if (ShoppingCart == null)
            {
                ShoppingCart = new ShoppingCart
                {
                    SCartId = SCartId,
                    Tobacco = tobacco,
                    Quantity = 1
                };
                _context.ShoppingCarts.Add(ShoppingCart);
            }
            else
            {
                ShoppingCart.Quantity++;
            }
            _context.SaveChanges();
        }

        public int RemoveCart(Tobacco tobacco)
        {
            var ShoppingCart =
                    _context.ShoppingCarts.SingleOrDefault(
                        s => s.Tobacco.TobaccoId == tobacco.TobaccoId && s.SCartId == SCartId);

            var quantityLocal = 0;

            if (ShoppingCart != null)
            {
                if (ShoppingCart.Quantity > 1)
                {
                    ShoppingCart.Quantity--;
                    quantityLocal = ShoppingCart.Quantity;
                }
                else
                {
                    _context.ShoppingCarts.Remove(ShoppingCart);
                }
            }
            _context.SaveChanges();
            return quantityLocal;
        }

        public List<ShoppingCart> GetShoppingCart()
        {
            return ShoppingCarts ??
                   (ShoppingCarts =
                       _context.ShoppingCarts.Where(c => c.SCartId == SCartId)
                           .Include(s => s.Tobacco)
                           .ToList());
        }

        public void CleanCart()
        {
            var cartItens = _context.ShoppingCarts
                                 .Where(cart => cart.SCartId == SCartId);

            _context.ShoppingCarts.RemoveRange(cartItens);
            _context.SaveChanges();
        }

        public decimal GetCartTotal()
        {
            var total = _context.ShoppingCarts.Where(c => c.SCartId == SCartId)
                .Select(c => c.Tobacco.Price * c.Quantity).Sum();
            return total;
        }
    }
}