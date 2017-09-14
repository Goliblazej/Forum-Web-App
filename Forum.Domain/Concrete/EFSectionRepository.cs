using System.Collections.Generic;
using Forum.Domain.Abstract;
using Forum.Domain.Entities;

namespace Forum.Domain.Concrete
{
    public class EFSectionRepository : ISectionRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Section> Sections
        {
            get { return context.Sections; }
        }
    }
}