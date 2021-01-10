using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CategoryService1.Models;

namespace CategoryService1.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(ProductCreate product);
        Task<Product> GetProductById(int id);
        Task<IEnumerable<Product>> GetProductsByCategoryId(int id);
        Task<bool> ChangeCategory(ProductInfo product);
    }
}
