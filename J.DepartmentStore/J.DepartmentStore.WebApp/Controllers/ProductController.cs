using J.DepartmentStore.Domain.Abstract;
using J.DepartmentStore.Domain.Concrete;
using J.DepartmentStore.Domain.Entities;
using J.DepartmentStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace J.DepartmentStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository ProductsRepository { get; set; }

        public const int PageSize = 5;

        
        public ViewResult List(int page=1)
        {
            ProductsListViewModel model = new ProductsListViewModel()
            {
                products = ProductsRepository
                .Products
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = ProductsRepository.Products.Count()
                }
            };
            return View(model);
        }
        
    }
}