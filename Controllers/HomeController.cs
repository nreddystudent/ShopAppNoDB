using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Com_Website.Data.Interfaces;
using E_Com_Website.Data.Models;
using E_Com_Website.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Com_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productData;
        private readonly ShoppingCart shoppingCartData;

        public HomeController(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            productData = productRepository;
            shoppingCartData = shoppingCart;

        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredProducts = productData.PreferredProducts,
                ShoppingCart = shoppingCartData
            };
             return View(homeViewModel);
        }
    }
}