using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Com_Website.Data.Interfaces;
using E_Com_Website.Data.Models;
using Microsoft.AspNetCore.Mvc;
using E_Com_Website.ViewModels;
namespace E_Com_Website.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository productData;
        private readonly ShoppingCart shoppingCartData;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            productData = productRepository;
            shoppingCartData = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = shoppingCartData.GetShoppingCartItems();
            shoppingCartData.ShoppingCartItems = items;
            var ShoppingCartVM = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCartData,
                ShoppingCartTotal = shoppingCartData.GetShoppingCartTotal()
            };
            return View(ShoppingCartVM);
        }
        [Route("ShoppingCart/AddToShoppingCart/{productId}")]
        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = productData.Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                shoppingCartData.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("List", "Product");
        }

        [Route("ShoppingCart/AddOneToShoppingCart/{productId}")]
        public RedirectToActionResult AddOneToShoppingCart(int productId)
        {
            var selectedProduct = productData.Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                shoppingCartData.AddOneToCart(selectedProduct, 1);
            }
            return RedirectToAction("Index");
        }

        [Route("ShoppingCart/RemoveOneFromShoppingCart/{productId}")]
        public RedirectToActionResult RemoveOneFromShoppingCart(int productId)
        {
            var selectedProduct = productData.Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                shoppingCartData.RemoveOneFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }

        [Route("ShoppingCart/RemoveFromShoppingCart/{productId}")]
        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = productData.Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                shoppingCartData.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }
    }
}