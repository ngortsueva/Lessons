using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstract;
using Domain.Entities;

namespace Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }

        public void SaveProduct(Product product)
        {
            if (product.ProductID == 0)
            {
                context.Products.Add(product);
            }
            else {
                Product temp = context.Products.FirstOrDefault(p => p.ProductID == product.ProductID);

                temp.Name = product.Name;
                temp.Description = product.Description;
                temp.Category = product.Category;
                temp.Price = product.Price;
                temp.ImageData = product.ImageData;
                temp.ImageMimeType = product.ImageMimeType;
            }
            context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
