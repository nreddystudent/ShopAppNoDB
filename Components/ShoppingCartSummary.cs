using E_Com_Website.Data.Models;
using E_Com_Website.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Com_Website.Components
{
    public class ShoppingCartSummary: ViewComponent
    {
        private readonly ShoppingCart shoppingCartData;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            shoppingCartData = shoppingCart;
        }
        public IViewComponentResult Invoke()
        {
            var items = shoppingCartData.GetShoppingCartItems();
            shoppingCartData.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCartData,
                ShoppingCartTotal = shoppingCartData.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
