using System.Collections.Generic;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Linq;

namespace DataAccess.Infrastructure
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BethanysPieShopContext _context;

        public CategoryRepository(BethanysPieShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories.AsEnumerable();
    }
}
