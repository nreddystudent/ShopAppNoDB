using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Com_Website.Data.Models;
namespace E_Com_Website.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart{get; set;}
        public decimal ShoppingCartTotal { get; set; }

    }
}
