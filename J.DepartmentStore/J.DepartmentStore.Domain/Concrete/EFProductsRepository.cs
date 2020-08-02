using J.DepartmentStore.Domain.Abstract;
using J.DepartmentStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.DepartmentStore.Domain.Concrete
{
    public class EFProductsRepository : IProductsRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }

    }
}
