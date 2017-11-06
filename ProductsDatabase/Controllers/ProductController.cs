using ProductsDatabase.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductsDatabase.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository productRepository)
        {
            repository = productRepository;
        }
        
        // GET: Product
        public ActionResult ProductList()

        {
            return View(repository.Products);
        }
    }
}