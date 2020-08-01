using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using J.DepartmentStore.Domain.Concrete;
using J.DepartmentStore.Domain.Entities;

namespace J.DepartmentStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            using (var ctx= new EFDbContext())
            {
                for (int i = 0; i < 30; i++)
                {
                    var product = new Product()
                    {
                        Name = $"Glasses-{i}",
                        Price = i+0.1m,
                        Category = "Accessory",
                        Description = $"This is glasses {i}."
                    };
                    ctx.Products.Add(product);

                }
                ctx.SaveChanges();
            }

            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}
