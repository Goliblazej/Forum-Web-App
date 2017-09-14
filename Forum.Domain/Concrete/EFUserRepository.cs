using System.Collections.Generic;
using Forum.Domain.Abstract;
using Forum.Domain.Entities;

namespace Forum.Domain.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }
    }
}