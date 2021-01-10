using System;
using System.Threading.Tasks;
using CategoryService1.Models;

namespace CategoryService1.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> AddCategory(CategoryCreate category);
        Task<Category> GetCategoryById(int id);
    }
}
