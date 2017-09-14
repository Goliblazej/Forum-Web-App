using System.Collections.Generic;
using Forum.Domain.Abstract;
using Forum.Domain.Entities;

namespace Forum.Domain.Concrete
{
    public class EFTopicRepository : ITopicRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Topic> Topics
        {
            get { return context.Topics; }
        }
    }
}