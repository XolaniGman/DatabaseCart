using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseCart.Models
{
    public class ProductModel
    {
       ApplicationDbContext db = new ApplicationDbContext();
         private List<Product> products ;

        public ProductModel()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var Product = new List<Product>();
          
             
        }

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(string id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }
    }
}
