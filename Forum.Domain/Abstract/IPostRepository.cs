using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Domain.Entities;

namespace Forum.Domain.Abstract
{
    public interface IPostRepository
    {
        IEnumerable<Post> Posts { get; }
    }
}
