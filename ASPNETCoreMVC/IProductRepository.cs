using System;
using System.Collections.Generic;
using ASPNETCoreMVC.Models;

namespace ASPNETCoreMVC
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
    }
}
