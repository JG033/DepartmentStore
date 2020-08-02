using J.DepartmentStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace J.DepartmentStore.WebApp.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> products { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}