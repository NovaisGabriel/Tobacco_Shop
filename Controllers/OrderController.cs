using Tobacco_Shop.Models;
using Tobacco_Shop.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tobacco_Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly Cart _cart;

        public OrderController(IOrderRepository orderRepository, Cart cart)
        {
            _orderRepository = orderRepository;
            _cart = cart;
        }
        // [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        // [Authorize]
        public IActionResult Checkout(Order order)
        {
            var items = _cart.GetShoppingCart();

            _cart.ShoppingCarts = items;

            if (_cart.ShoppingCarts.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, maybe you should buy something...");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);

                ViewBag.CheckoutCompleteMsg = "Thanks for your order :) ";
                ViewBag.TotalOrder = _cart.GetCartTotal();

                _cart.CleanCart();
                return View("~/Views/Order/CheckoutCompleto.cshtml", order);
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.Client = TempData["Client"];
            ViewBag.DateOrder = TempData["DateOrder"];
            ViewBag.NumberOrder = TempData["NumberOrder"];
            ViewBag.TotalOrder = TempData["TotalOrder"];
            ViewBag.CheckoutCompleteMsg = "Thanks for your order :) ";
            return View();
        }
    }
}