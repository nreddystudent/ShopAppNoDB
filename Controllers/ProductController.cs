using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Com_Website.Data.Interfaces;
using E_Com_Website.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Com_Website.Controllers
{
    public class ProductController : Controller
    { 
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepsitory;
        public ProductController(ICategoryRepository categoryRepository, IProductRepository productRepository){
            this._categoryRepository = categoryRepository;
            this._productRepsitory = productRepository;
        }

        public ViewResult List(string category)
        {
            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = _productRepsitory.Products;
            vm.CurrentCategory = "Shop";
            if (string.IsNullOrEmpty(category))
            {
                vm.Products = _productRepsitory.Products;
            }
            else
            {
                if (category == "Tops")
                {
                    vm.Products = _productRepsitory.Products.Where(p => p.CategoryId.Equals(1));
                    vm.CurrentCategory = category;
                }
                else if (category == "Bottoms")
                {
                    vm.Products = _productRepsitory.Products.Where(p => p.CategoryId.Equals(2));
                    vm.CurrentCategory = category;
                }
                else
                    vm.CurrentCategory = "Shop";
            }
            return View(vm);
        }
    }
}