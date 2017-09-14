using System.Collections.Generic;
using Forum.Domain.Abstract;
using Forum.Domain.Entities;

namespace Forum.Domain.Concrete
{
    public class EFPostRepository : IPostRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Post> Posts
        {
            get { return context.Posts; }
        }
    }
}