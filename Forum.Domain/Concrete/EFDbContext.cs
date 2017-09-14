using Forum.Domain.Entities;
using System.Data.Entity;

namespace Forum.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Section> Sections { get; set; }
    }
}
