using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentPromact.Models
{
    public interface IPostsRepository
    {
        Posts GetPosts(int id);
        IEnumerable<Posts> GetAllPosts();
        IEnumerable<Comments> GetAllComments(int id);

    }
}
