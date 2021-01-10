using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CategoryService1.Data;
using CategoryService1.Models;
using CategoryService1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CategoryService1.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }


        public async Task<Product> AddProduct(ProductCreate product)
        {
            var productToCreate = new Product()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                CategoryId = product.CategoryId
            };
            await _context.Products.AddAsync(productToCreate);
            await _context.SaveChangesAsync();
            return productToCreate;
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryId(int id)
        {
            return await _context.Products.Where(x => x.CategoryId == id).ToListAsync();
        }

        public async Task<bool> ChangeCategory(ProductInfo product)
        {
            var productToUpdate = await _context.Products.Where(x => x.Id == product.Id).FirstOrDefaultAsync();
            productToUpdate.CategoryId = product.CategoryId.Id;
            return await (_context.SaveChangesAsync()) > 0;
        }
    }
}
