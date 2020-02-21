using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Com_Website.Data.Models;
namespace E_Com_Website.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
