using ProductsDatabase.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsDatabase.Models.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}