using J.DepartmentStore.Domain.Abstract;
using J.DepartmentStore.Domain.Concrete;
using J.DepartmentStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace J.DepartmentStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository ProductsRepository { get; set; }
        = new InMemeoryProductsRepository();
        // GET: Product

        public ViewResult List()
        {
            var model = ProductsRepository.Products;
            return View(model);
        }
        
    }
}