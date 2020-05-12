using Tobacco_Shop.Models;
using Tobacco_Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Tobacco_Shop.Components
{
    public class CartAbstract : ViewComponent
    {
        private readonly Cart _cart;

        public CartAbstract(Cart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _cart.GetShoppingCart();

            _cart.ShoppingCarts = items;

            var cartVM = new CartViewModel
            {
                Cart = _cart,
                CartTotal = _cart.GetCartTotal()
            };
            return View(cartVM);
        }
    }
}
