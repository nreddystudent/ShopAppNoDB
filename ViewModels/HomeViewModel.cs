using E_Com_Website.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Com_Website.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable PreferredProducts { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
