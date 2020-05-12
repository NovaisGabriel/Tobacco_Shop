using Tobacco_Shop.Models;
using Tobacco_Shop.Repositories;
using Tobacco_Shop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Tobacco_Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly ITobaccoRepository _tobaccoRepository;
        private readonly Cart _cart;

        public CartController(ITobaccoRepository tobaccoRepository, Cart cart)
        {
            _tobaccoRepository = tobaccoRepository;
            _cart = cart;
        }
        public IActionResult Index()
        {
            var itens = _cart.GetShoppingCart();
            _cart.ShoppingCarts = itens;

            var cartVM = new CartViewModel
            {
                Cart = _cart,
                CartTotal = _cart.GetCartTotal()
            };

            return View(cartVM);
        }
        // [Authorize]
        public RedirectToActionResult AddItemCart(int tobaccoId)
        {
            var tobaccoSelection = _tobaccoRepository.Tobaccos.FirstOrDefault(p => p.TobaccoId == tobaccoId);

            if (tobaccoSelection != null)
            {
                _cart.AddCart(tobaccoSelection, 1);
            }
            return RedirectToAction("Index");
        }
        // [Authorize]
        public IActionResult RemoveItemCart(int tobaccoId)
        {
            var tobaccoSelection = _tobaccoRepository.Tobaccos.FirstOrDefault(p => p.TobaccoId == tobaccoId);
            if (tobaccoSelection != null)
            {
                _cart.RemoveCart(tobaccoSelection);
            }
            return RedirectToAction("Index");
        }
    }
}