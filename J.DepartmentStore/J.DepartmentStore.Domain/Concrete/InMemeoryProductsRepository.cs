using J.DepartmentStore.Domain.Abstract;
using J.DepartmentStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.DepartmentStore.Domain.Concrete
{
    public class InMemeoryProductsRepository : IProductsRepository
    {
        private List<Product> _products = new List<Product>
        {
            new Product {Name = "Glasses", Price = 99},
            new Product {Name = "Watches", Price = 199},
            new Product {Name = "Handbag", Price = 299},
            new Product {Name = "Furniture", Price = 599},
            new Product {Name = "Clothes", Price = 59}
        };

        public IEnumerable<Product> Products
        {
            get { return _products; }
        }
    }
}
