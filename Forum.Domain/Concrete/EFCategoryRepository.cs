using System.Collections.Generic;
using Forum.Domain.Abstract;
using Forum.Domain.Entities;

namespace Forum.Domain.Concrete
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Category> Categories
        {
            get { return context.Categories; }
        }
    }
}