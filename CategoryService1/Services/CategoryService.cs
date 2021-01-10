using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CategoryService1.Models;
using CategoryService1.Repositories.Interfaces;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace CategoryService1.Services
{
    public class CategoryService: Shop.ShopBase
    {
        private readonly ILogger<CategoryService> _logger;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public CategoryService(ILogger<CategoryService> logger, ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }



        public override async Task<CategoryInfo> AddCategory(CategoryCreate request, ServerCallContext context)
        {
            var res = await _categoryRepository.AddCategory(request);
            var categoryInfo = new CategoryInfo()
            {
                Id = res.Id,
                Name = res.Name,
                ParentCategory = res.ParentCategoryId
            };

            return await Task.FromResult(categoryInfo);
        }

        public override async Task<CategoryInfo> GetCategoryById(CategoryLookUp request, ServerCallContext context)
        {
            var res = await _categoryRepository.GetCategoryById(request.Id);
            var categoryInfo = new CategoryInfo()
            {
                Id = res.Id,
                Name = res.Name,
                ParentCategory = res.ParentCategoryId
            };

            return await Task.FromResult(categoryInfo);
        }



        public override async Task<ProductInfo> AddProduct(ProductCreate request, ServerCallContext context)
        {
            var res = await _productRepository.AddProduct(request);
            var category = await _categoryRepository.GetCategoryById(res.CategoryId);
            var categoryInfo = new CategoryInfo()
            {
                Id = category.Id,
                Name = category.Name,
                ParentCategory = category.ParentCategoryId
            };

            var productInfo = new ProductInfo()
            {
                Id = res.Id,
                Name = res.Name,
                Description = res.Description,
                Price = res.Price,
                CategoryId = categoryInfo
            };

            return await Task.FromResult(productInfo);
        }

        public override async Task<ProductInfo> getProdcutById(ProductLookUp request, ServerCallContext context)
        {
            var res = await _productRepository.GetProductById(request.Id);
            var category = await _categoryRepository.GetCategoryById(res.CategoryId);
            var categoryInfo = new CategoryInfo()
            {
                Id = category.Id,
                Name = category.Name,
                ParentCategory = category.ParentCategoryId
            };
            var productInfo = new ProductInfo()
            {
                Id = res.Id,
                Name = res.Name,
                Description = res.Description,
                Price = res.Price,
                CategoryId = categoryInfo
            };
            return await Task.FromResult(productInfo);
        }



        public override async Task getProductsByCategoryId(CategoryLookUp request, IServerStreamWriter<ProductInfo> responseStream, ServerCallContext context)
        {
            var res = await _productRepository.GetProductsByCategoryId(request.Id);
            foreach(var product in res)
            {

                await Task.Delay(1000);
                var category = await _categoryRepository.GetCategoryById(product.CategoryId);
                var categoryInfo = new CategoryInfo()
                {
                    Id = category.Id,
                    Name = category.Name,
                    ParentCategory = category.ParentCategoryId
                };
                var productInfo = new ProductInfo()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    CategoryId = categoryInfo
                };
                await responseStream.WriteAsync(productInfo);
            }
        }
    }
}
