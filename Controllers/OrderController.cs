using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Com_Website.Data.Interfaces;
using E_Com_Website.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Com_Website.Controllers
{   
    [Authorize]
    public class OrderController : Controller
    {

        Order order = new Order();
        private readonly ShoppingCart _shoppingCart;
        public OrderController(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IActionResult Checkout()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (ModelState.IsValid)
            {
                _shoppingCart.clearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            return View();
        }
    }
}
