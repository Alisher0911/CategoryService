using System;
using System.Linq;
using System.Threading.Tasks;
using CategoryService1.Data;
using CategoryService1.Models;
using CategoryService1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CategoryService1.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }


        public async Task<Category> AddCategory(CategoryCreate category)
        {
            var categoryToCreate = new Category()
            {
                Name = category.Name,
                ParentCategoryId = category.ParentCategory
            };
            await _context.Categories.AddAsync(categoryToCreate);
            await _context.SaveChangesAsync();
            return categoryToCreate;
        }


        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
     
        }
    }
}
