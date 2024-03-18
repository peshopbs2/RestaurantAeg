using RestaurantAeg.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAeg.Services.Abstractions
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task<Category> AddAsync(Category category);
        Task DeleteByIdAsync(int id);
        Task<Category> UpdateAsync(Category category);
    }
}
