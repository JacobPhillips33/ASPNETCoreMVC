using System;
using System.Collections.Generic;
using ASPNETCoreMVC.Models;

namespace ASPNETCoreMVC
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
